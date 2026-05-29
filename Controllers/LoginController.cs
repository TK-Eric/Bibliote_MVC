using bibliotec.Models;
using bibliotec.Interfaces;
using Microsoft.AspNetCore.Mvc;
using bibliotec.Models;

namespace bibliotec.Controllers
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