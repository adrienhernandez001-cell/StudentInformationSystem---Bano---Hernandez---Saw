using Microsoft.AspNetCore.Mvc;

namespace StudentInformationSystem.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}