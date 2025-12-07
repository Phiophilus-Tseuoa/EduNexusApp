namespace DemoMVP.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }   // ADD THIS
        public string Email { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }
}
