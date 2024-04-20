using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment4.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register()
        {
            return View();
        }
    }
}
