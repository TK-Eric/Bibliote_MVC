
using Base.Interfaces;
using Base.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Base.Controllers
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

        public async  Task<IActionResult> Logar(string email,
         string senha)
        {
            Usuario? usuario = await _usuarioService.
            AutenticarUsuario(email, senha);

            if (usuario != null)
            {
                HttpContext.Session.SetString("UsuarioId",
                usuario.Id.ToString());
                HttpContext.Session.SetString("Admin",
                usuario.TipoBib.ToString());

                return RedirectToAction ("index", "Home");
            }
            ViewBag.Erro = "Usuario ou Senha Inválidos";
            return View("Index");       
        }

    }
}