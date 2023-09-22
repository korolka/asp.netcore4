using Microsoft.AspNetCore.Mvc;

namespace AspUi5.Controllers
{
    public class Ex1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
