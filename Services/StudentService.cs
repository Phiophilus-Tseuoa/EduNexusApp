using DemoMVP.Models;

namespace DemoMVP.Services
{
    public class StudentService
    {
        private readonly List<Student> _students = new()
        {
            new Student { Email = "student1@university.edu", Name = "Student One" },
            new Student { Email = "student2@university.edu", Name = "Student Two" }
        };

        public Student? LoggedInStudent { get; set; }

        public Student? GetStudentByEmail(string email)
        {
            return _students.FirstOrDefault(s =>
                s.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }

        public List<string> GetStudentSubjects()
        {
            return new List<string> { "Math 101", "Science 201", "History 300" };
        }
    }
}
