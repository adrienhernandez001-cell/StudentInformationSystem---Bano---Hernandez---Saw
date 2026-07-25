using Microsoft.AspNetCore.Mvc;
using StudentInformationSystem.Data;

namespace StudentInformationSystem.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View(StudentRepository.Students);
        }
    }
}