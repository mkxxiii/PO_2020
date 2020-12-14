using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using AnimeList.Models;
using AnimeList.Class.ViewItens;

namespace AnimeList.Controllers
{
    public class EstudioController : Controller
    {
        dbPICC_20202Context dbContext = new dbPICC_20202Context();

        // GET: EstudioController
        public ActionResult Index()
        {
            var response = new EstudioViewItem();
            response.Estudios = dbContext.Estudios.ToList();

            return View(response);
        }

        // GET: EstudioController/Edit/5
        public ActionResult Edit(int id)
        {
            var obj = id == 0 ? new Estudio() : dbContext.Estudios.First(a => a.Id == id);
            return View(obj);
        }

        // POST: EstudioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Estudio obj)
        {
            try
            {
                if(obj.Id == 0)
                {
                    dbContext.Estudios.Add(obj);
                }
                else
                {
                    var objToUpdate = dbContext.Estudios.First(a => a.Id == obj.Id);

                    objToUpdate.Nome = obj.Nome;
                }

                dbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EstudioController/Delete/5
        public ActionResult Delete(int id)
        {
            var response = new EstudioViewItem();
            var obj = dbContext.Estudios.First(a => a.Id == id);

            obj.Animes = dbContext.Animes.Where(a => a.IdEstudio == id).ToList();

            if (obj.Animes == null || obj.Animes.Count < 1)
            {
                response.DevolverMensagemParaView(true, "Registro deletado com sucesso!");

                dbContext.Estudios.Remove(obj);

                dbContext.SaveChanges();
            }
            else
            {
                response.DevolverMensagemParaView(false, "Registro não pode ser deletado pois existe dependência!");
            }

            response.Estudios = dbContext.Estudios.ToList();

            return View("Index", response);
        }
    }
}
