using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using AnimeList.Models;
using AnimeList.Class.ViewItens;

namespace AnimeList.Controllers
{
    public class DiretorController : Controller
    {
        dbPICC_20202Context dbContext = new dbPICC_20202Context();

        // GET: DiretorController
        public ActionResult Index()
        {
            var response = new DiretorViewItem();
            response.Diretores = dbContext.Diretors.ToList();

            return View(response);
        }

        // GET: DiretorController/Edit/5
        public ActionResult Edit(int id)
        {
            var obj = id == 0 ? new Diretor() : dbContext.Diretors.First(a => a.Id == id);
            return View(obj);
        }

        // POST: DiretorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Diretor obj)
        {
            try
            {
                if (obj.Id == 0)
                {
                    dbContext.Diretors.Add(obj);
                }
                else
                {
                    var objToUpdate = dbContext.Diretors.First(a => a.Id == obj.Id);

                    objToUpdate.Nome = obj.Nome;
                    objToUpdate.DataNascimento = obj.DataNascimento;
                    objToUpdate.Sexo = obj.Sexo;
                }

                dbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DiretorController/Delete/5
        public ActionResult Delete(int id)
        {
            var response = new DiretorViewItem();
            var obj = dbContext.Diretors.First(a => a.Id == id);

            obj.Animes = dbContext.Animes.Where(a => a.IdEstudio == id).ToList();

            if (obj.Animes == null || obj.Animes.Count < 1)
            {
                response.DevolverMensagemParaView(true, "Registro deletado com sucesso!");

                dbContext.Diretors.Remove(obj);

                dbContext.SaveChanges();
            }
            else
            {
                response.DevolverMensagemParaView(false, "Registro não pode ser deletado pois existe dependência!");
            }

            response.Diretores = dbContext.Diretors.ToList();

            return View("Index", response);
        }
    }
}
