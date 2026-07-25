using System.ComponentModel.DataAnnotations;

namespace StudentInformationSystem.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Student Number is required.")]
        public string StudentNumber { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Course is required.")]
        public string Course { get; set; }

        [Range(1, 4, ErrorMessage = "Year Level must be between 1 and 4.")]
        public int YearLevel { get; set; }
    }
}