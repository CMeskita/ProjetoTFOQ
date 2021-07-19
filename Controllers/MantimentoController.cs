using ProjetoTfoq.Models;
using ProjetoTfoq.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoTfoq.Controllers
{
    public class MantimentoController : Controller
    {
        MantimentoRepository repository = new MantimentoRepository();
        // GET: Mantimento
        public ActionResult Index()
        {
            List<Mantimento> mantimento = new MantimentoRepository().GetAll();
            return View(mantimento);
        }

        public ActionResult Cadastro()
        {
            ViewBag.Tipos = new TipoRepository().GetAll();
            return View();
        }
        public ActionResult Alterar(int id)
        {
            Mantimento mantimento = repository.Get(id);
            return View(mantimento);
        }
        public ActionResult Detalhes(int id)
        {
            Mantimento mantimento = repository.Get(id);
            return View(mantimento);
        }
        [HttpGet]
        public JsonResult Get(int id)
        {
            Mantimento mantimento = repository.Get(id);
            return Json(mantimento);
        }

        [HttpPost]
        public JsonResult Add(Mantimento mantimento)
        {
            repository.Add(mantimento);
            return Json("Cadastado com Sucesso");
        }
        [HttpPost]
        public JsonResult Update(Mantimento mantimento)
        {
            repository.Update(mantimento);

            return Json("Alterado com Sucesso");
        }

        public JsonResult Delete(int id)
        {
            repository.Delete(id);
            return Json("Removido com Sucesso", JsonRequestBehavior.AllowGet);
        }
    }
}