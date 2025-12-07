namespace AttendanceManagementSystem.Models.DTOs
{
    public class TeacherSubjectDto
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; } = string.Empty;

        // Optional properties for UI
        public string GradeLevel { get; set; } = string.Empty;
        public string Section { get; set; } = string.Empty;
    }
}
