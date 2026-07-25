using StudentInformationSystem.Models;

namespace StudentInformationSystem.Data
{
    public static class StudentRepository
    {
        public static List<Student> Students = new List<Student>()
        {
            new Student
            {
                Id = 1,
                StudentNumber = "2025-001",
                FirstName = "Juan",
                LastName = "Dela Cruz",
                Course = "BSIT",
                YearLevel = 1
            },

            new Student
            {
                Id = 2,
                StudentNumber = "2025-002",
                FirstName = "Maria",
                LastName = "Santos",
                Course = "BSCS",
                YearLevel = 2
            },

            new Student
            {
                Id = 3,
                StudentNumber = "2025-003",
                FirstName = "Pedro",
                LastName = "Reyes",
                Course = "BSIT",
                YearLevel = 3
            }
        };
    }
}