using Bibliotec_MVC.Models;
using Bibliotec_MVC.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Bibliotec_MVC.Controllers
{
    
    public class LoginController : Controller
    {
        
        private readonly IUsuarioService  _usuarioService;
        
        
        public LoginController (IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public IActionResult Index()
        {

            return View();
        }


[HttpPost]

        public async  Task<IActionResult> Cadastro()
        {
            string? adminSessao = HttpContext.Session.GetString("Admin");
            if (adminSessao != null || (adminSessao != "true" && adminSessao != "True"))
            
            {
                return RedirectToAction ("index", "Login");
            }
            ViewBag.Admin = "Usuario ou Senha Inválidos";
            return View("Index");       
        }


        [HttpPost]

        public async  Task<IActionResult> Logar(string email, string senha)
        {
            Usuario? usuario = await _usuarioService.
            AutenticarUsuario(email, senha);

            if (usuario != null)
            {
                HttpContext.Session.SetString("UsuarioId",usuario.Id.ToString());
                HttpContext.Session.SetString("Admin",usuario.tipoBib.ToString());

                return RedirectToAction ("index", "Livro");
            }
            ViewBag.Erro = "Usuario ou Senha Inválidos";
            return View("Index");       
        }

        [HttpPost]

        public ActionResult Deslogar()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

    }
}