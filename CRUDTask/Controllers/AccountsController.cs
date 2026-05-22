using Microsoft.AspNetCore.Mvc;

namespace CRUDTask.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Login()
        {
            return View("Login");
        }
        public IActionResult Register()
        {
            return View("Register");
        }
    }
}
