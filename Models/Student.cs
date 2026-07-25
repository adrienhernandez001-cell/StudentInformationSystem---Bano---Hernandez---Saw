namespace StudentInformationSystem.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string StudentNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Course { get; set; }

        public int YearLevel { get; set; }
    }
}