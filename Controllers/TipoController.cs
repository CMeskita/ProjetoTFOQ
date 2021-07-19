using ProjetoTfoq.Models;
using ProjetoTfoq.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoTfoq.Controllers
{
    public class TipoController : Controller
    {
        //Para cadastrar o Tipo tenho que chamar o repository
        TipoRepository tiporep = new TipoRepository();
        // GET: Tipo
        public ActionResult Index()
        {
            List<Tipo> tipo = new TipoRepository().GetAll();
            return View(tipo);
        }
        //No Controle crio a Action onde vai direcionar para a minha View, Criando a Pagina no Site
        public ActionResult Cadastro()
        {
            return View();
        }
        public ActionResult Alterar(int id)
        {
            Tipo tipo = tiporep.Get(id);
            return View(tipo);
        }
        public ActionResult Detalhes(int id)
        {
            Tipo tipo = tiporep.Get(id);
            return View(tipo);
        }
        [HttpGet]
        public JsonResult Get(int id)
        {
            Tipo tipo = tiporep.Get(id);
            return Json(tipo);
        }
        //Receber como parametro o tipo com isso vou mandar do back and para o fronte and
        [HttpPost]
        public JsonResult Add(Tipo tipo) 
        {
            tiporep.AddTipo(tipo);
            return Json("Cadastado com Sucesso");
        }
        [HttpPost]
        public JsonResult Update(Tipo tipo)
        {
            tiporep.UpdateTipo(tipo);
           
            return Json("Alterado com Sucesso");
        }
       
        public JsonResult Delete(int id)
        {
            tiporep.DeleteTipo(id);
            return Json("Removido com Sucesso",JsonRequestBehavior.AllowGet);
        }
    }
}