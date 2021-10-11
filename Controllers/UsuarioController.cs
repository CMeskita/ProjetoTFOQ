using ProjetoTfoq.Models;
using ProjetoTfoq.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoTfoq.Controllers
{
    public class UsuarioController : Controller
    {
        UsuarioRepository repository = new UsuarioRepository();
        // GET: Usuario
        public ActionResult Index()
        {
            List<Usuario> usuario = new UsuarioRepository().GetAll();
            return View(usuario);
        }
        public ActionResult Cadastro()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Add(Usuario usuario)
        {
            repository.Add(usuario);
            return Json("Cadastado com Sucesso");
        }
    }
}