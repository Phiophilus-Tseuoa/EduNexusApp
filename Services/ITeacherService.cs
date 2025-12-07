using AttendanceManagementSystem.Models.DTOs;

namespace AttendanceManagementSystem.Services
{
    public interface ITeacherService
    {
        Task<List<TeacherSubjectDto>> GetTeacherSubjects(int teacherId);
        Task<List<TeacherStudentDto>> GetStudentsForSubject(int subjectId, int teacherId);
    }
}
