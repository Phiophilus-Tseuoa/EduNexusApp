using System.Net.Http.Json;
using AttendanceManagementSystem.Models.DTOs;

namespace AttendanceManagementSystem.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly HttpClient _http;

        public TeacherService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<TeacherSubjectDto>> GetTeacherSubjects(int teacherId)
        {
            return await _http.GetFromJsonAsync<List<TeacherSubjectDto>>(
                $"api/teachers/{teacherId}/subjects"
            ) ?? new List<TeacherSubjectDto>();
        }

        public async Task<List<TeacherStudentDto>> GetStudentsForSubject(int subjectId, int teacherId)
        {
            return await _http.GetFromJsonAsync<List<TeacherStudentDto>>(
                $"api/teachers/{teacherId}/subjects/{subjectId}/students"
            ) ?? new List<TeacherStudentDto>();
        }
    }
}
