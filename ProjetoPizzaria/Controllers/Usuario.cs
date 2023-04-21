using Microsoft.AspNetCore.Mvc;

namespace ProjetoPizzaria.Controllers
{
    public class Usuario : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
