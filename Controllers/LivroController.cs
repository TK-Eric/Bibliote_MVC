using System.Reflection.Metadata;
using Bibliotec_MVC.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace bibliotec.Controllers
{

    public class LivroController : Controller
    {
        
        private readonly ILivroService _livroService;

        public LivroController(ILivroService livroService)
        {
            _livroService = livroService;
        }
        public async Task<IActionResult> Index()
        {
             string? adminSessao = HttpContext.Session.GetString
            ("Admin");

            if(adminSessao == null)
            {
                return RedirectToAction("Index", "Login");
            }

            ViewBag.Admin = adminSessao == "True" || adminSessao == "true";

            var livros = await _livroService.BuscarLivrosAsync();

            return View(livros);
        }

        
    }
}