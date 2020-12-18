using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using AnimeList.Models;
using AnimeList.Class.ViewItens;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;


namespace AnimeList.Controllers
{
    public class AnimeController : Controller
    {
        dbPICC_20202Context dbContext = new dbPICC_20202Context();

        public IActionResult Index()
        {
            var response = new CadastroAnimeViewItem();
            response.Animes = dbContext.Animes.ToList();

            return View(response);
        }

        public ActionResult Edit(int id)
        {
            var obj = new CadastroAnimeViewItem();

            obj.Diretores = new List<SelectListItem>();
            obj.Temporadas = new List<SelectListItem>();
            obj.Estudios = new List<SelectListItem>();

            var lstDiretores = dbContext.Diretors.ToList();
            var lstTemporadas = dbContext.Temporada.ToList();
            var lstEstudio = dbContext.Estudios.ToList();

            lstDiretores.ForEach(a => obj.Diretores.Add(new SelectListItem { Value = a.Id.ToString(), Text = a.Nome, Selected = false}));
            lstTemporadas.ForEach(a => obj.Temporadas.Add(new SelectListItem { Value = a.Id.ToString(), Text = a.Ano + " " + a.Estacao, Selected = false }));
            lstEstudio.ForEach(a => obj.Estudios.Add(new SelectListItem { Value = a.Id.ToString(), Text = a.Nome, Selected = false }));

            obj.AnimeCadastro = id == 0 ? new Anime() : dbContext.Animes.First(a => a.Id == id);

            if(id != 0)
            {
                obj.Diretores.First(a => a.Value == obj.AnimeCadastro.IdDiretor.ToString()).Selected = true;
                obj.Temporadas.First(a => a.Value == obj.AnimeCadastro.IdTemporada.ToString()).Selected = true;
                obj.Estudios.First(a => a.Value == obj.AnimeCadastro.IdEstudio.ToString()).Selected = true;
            }
            

            return View(obj);
        }

        public ActionResult Watch(int id)
        {
            var obj = new EpisodioViewItem();
            obj.Anime = dbContext.Animes.First(a => a.Id == id);
            obj.Episodios = dbContext.Episodios.Where(a => a.IdAnime == id).ToList();

            return View(obj);
        }

        public ActionResult WatchEp(int id)
        {
            var obj = dbContext.Episodios.First(a => a.Id == id);
            obj.Visualizado = !obj.Visualizado;
            dbContext.SaveChanges();

            var objResponse = new EpisodioViewItem();
            objResponse.Anime = dbContext.Animes.First(a => a.Id == obj.IdAnime);
            objResponse.Episodios = dbContext.Episodios.Where(a => a.IdAnime == obj.IdAnime).ToList();

            return View("Watch", objResponse);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CadastroAnimeViewItem objEntrada)
        {
            try
            {
                var obj = objEntrada.AnimeCadastro;

                if (obj.Id == 0)
                {
                    dbContext.Animes.Add(obj);
                    dbContext.SaveChanges();

                    for (int i = 1; i <= objEntrada.qtdEpisodios; i++)
                    {
                        dbContext.Episodios.Add(new Episodio() { IdAnime = obj.Id, NomeEpisodio = "Episodio " + i, Duracao = 20, DataPrevista = System.DateTime.Now, NumeroEpisodio = System.Convert.ToInt16(i) });
                    }
                }
                else
                {
                    var objToUpdate = dbContext.Animes.First(a => a.Id == obj.Id);

                    objToUpdate.Nome = obj.Nome;
                    objToUpdate.NomeRomaji = obj.NomeRomaji;
                    objToUpdate.IdTemporada = obj.IdTemporada;
                    objToUpdate.IdDiretor = obj.IdDiretor;
                    objToUpdate.IdEstudio = obj.IdEstudio;
                }

                dbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            var response = new CadastroAnimeViewItem();
            var obj = dbContext.Animes.First(a => a.Id == id);

            response.DevolverMensagemParaView(true, "Registro deletado com sucesso!");

            dbContext.Episodios.RemoveRange(dbContext.Episodios.Where(a => a.IdAnime == id));
            dbContext.AnimeGeneros.RemoveRange(dbContext.AnimeGeneros.Where(a => a.IdAnime == id));
            dbContext.Animes.Remove(obj);

            dbContext.SaveChanges();

            response.Animes = dbContext.Animes.ToList();

            return View("Index", response);
        }
    }
}
