using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Base.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
