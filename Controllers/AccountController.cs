using Microsoft.AspNetCore.Mvc;

namespace StudentInformationSystem.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "admin123")
            {
                return RedirectToAction("Index", "Dashboard");
            }

            ViewBag.Error = "Invalid username or password.";

            return View();
        }
    }
}
        public IActionResult Index()
        {
            return View();
        }
    }
}
