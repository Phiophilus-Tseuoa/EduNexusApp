using DemoMVP.Models;

namespace DemoMVP.Services
{
    public class TeacherDataService
    {
        private readonly List<Teacher> _teachers = new()
        {
            new Teacher { TeacherId = 1, Email = "teacher1@university.edu", Name = "Teacher One" },
            new Teacher { TeacherId = 2, Email = "teacher2@university.edu", Name = "Teacher Two" }
        };

        public Teacher? LoggedInTeacher { get; set; }

        public Teacher? GetTeacherByEmail(string email)
        {
            return _teachers.FirstOrDefault(t => 
                t.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }
    }
}
