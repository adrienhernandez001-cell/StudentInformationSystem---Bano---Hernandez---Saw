using Microsoft.AspNetCore.Mvc;

namespace StudentInformationSystem.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
