using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment4.Controllers
{
    public class RegisterViewModelController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult ThankYou()
        {
            return View();
        }
    }
}
