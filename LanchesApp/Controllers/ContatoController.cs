using Microsoft.AspNetCore.Mvc;

namespace LanchesApp.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }
            return View("Login", "Account");
        }
    }
}
