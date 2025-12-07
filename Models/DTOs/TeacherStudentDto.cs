namespace AttendanceManagementSystem.Models.DTOs
{
    public class TeacherStudentDto
    {
        public int StudentId { get; set; }
        public string FullName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        // For attendance later
        public bool IsPresent { get; set; }
    }
}
