using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using AnimeList.Models;
using AnimeList.Class.ViewItens;


namespace AnimeList.Controllers
{
    public class GeneroController : Controller
    {
        dbPICC_20202Context dbContext = new dbPICC_20202Context();

        // GET: GeneroController
        public ActionResult Index()
        {
            var response = new GeneroViewItem();
            response.Generos = dbContext.Generos.ToList();

            return View(response);
        }

        // GET: GeneroController/Edit/5
        public ActionResult Edit(int id)
        {
            var obj = id == 0 ? new Genero() : dbContext.Generos.First(a => a.Id == id);
            return View(obj);
        }

        // POST: GeneroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Genero obj)
        {
            try
            {
                if (obj.Id == 0)
                {
                    dbContext.Generos.Add(obj);
                }
                else
                {
                    var objToUpdate = dbContext.Generos.First(a => a.Id == obj.Id);

                    objToUpdate.Descricao = obj.Descricao;
                }

                dbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: GeneroController/Delete/5
        public ActionResult Delete(int id)
        {
            var response = new GeneroViewItem();
            var obj = dbContext.Generos.First(a => a.Id == id);

            obj.AnimeGeneros = dbContext.AnimeGeneros.Where(a => a.IdGenero == id).ToList();

            if (obj.AnimeGeneros == null || obj.AnimeGeneros.Count < 1)
            {
                response.DevolverMensagemParaView(true, "Registro deletado com sucesso!");

                dbContext.Generos.Remove(obj);

                dbContext.SaveChanges();
            }
            else
            {
                response.DevolverMensagemParaView(false, "Registro não pode ser deletado pois existe dependência!");
            }

            response.Generos = dbContext.Generos.ToList();

            return View("Index", response);
        }
    }
}
