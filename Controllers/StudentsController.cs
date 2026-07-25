using Microsoft.AspNetCore.Mvc;
using StudentInformationSystem.Data;
using StudentInformationSystem.Models;

namespace StudentInformationSystem.Controllers
{
    public class StudentsController : Controller
    {
        // Display Student List with Search
        public IActionResult Index(string search)
        {
            var students = StudentRepository.Students.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();

                students = students.Where(s =>
                    s.StudentNumber.ToLower().Contains(search) ||
                    s.FirstName.ToLower().Contains(search) ||
                    s.LastName.ToLower().Contains(search) ||
                    s.Course.ToLower().Contains(search));
            }

            return View(students.ToList());
        }

        // ==========================
        // CREATE
        // ==========================

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }

            student.Id = StudentRepository.Students.Any()
                ? StudentRepository.Students.Max(s => s.Id) + 1
                : 1;

            StudentRepository.Students.Add(student);

            return RedirectToAction("Index");
        }

        // ==========================
        // EDIT
        // ==========================

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student = StudentRepository.Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }

            var existingStudent = StudentRepository.Students.FirstOrDefault(s => s.Id == student.Id);

            if (existingStudent == null)
            {
                return NotFound();
            }

            existingStudent.StudentNumber = student.StudentNumber;
            existingStudent.FirstName = student.FirstName;
            existingStudent.LastName = student.LastName;
            existingStudent.Course = student.Course;
            existingStudent.YearLevel = student.YearLevel;

            return RedirectToAction("Index");
        }

        // ==========================
        // DELETE
        // ==========================

        public IActionResult Delete(int id)
        {
            var student = StudentRepository.Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            StudentRepository.Students.Remove(student);

            return RedirectToAction("Index");
        }
    }
}