using Microsoft.AspNetCore.Mvc;
using StudentInformationSystem.Data;

namespace StudentInformationSystem.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index(string search)
        {
            var students = StudentRepository.Students.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();

                students = students.Where(s =>
                    s.FirstName.ToLower().Contains(search) ||
                    s.LastName.ToLower().Contains(search) ||
                    s.StudentNumber.ToLower().Contains(search) ||
                    s.Course.ToLower().Contains(search));
            }

            return View(students.ToList());
        }
    }
}