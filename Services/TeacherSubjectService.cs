using System.Net.Http.Json;
using AttendanceManagementSystem.Models.DTOs;

namespace DemoMVP.Services
{
    public class TeacherSubjectService
    {
        private readonly HttpClient _http;

        public TeacherSubjectService(HttpClient http)
        {
            _http = http;
        }

        // GET teacher subjects
        public async Task<List<TeacherSubjectDto>> GetTeacherSubjects(string teacherEmail)
        {
            return await _http.GetFromJsonAsync<List<TeacherSubjectDto>>
                ($"api/teacher/{teacherEmail}/subjects")
                   ?? new List<TeacherSubjectDto>();
        }

        // GET students under a subject
        public async Task<List<TeacherStudentDto>> GetStudentsBySubject(int subjectId)
        {
            return await _http.GetFromJsonAsync<List<TeacherStudentDto>>
                ($"api/teacher/subjects/{subjectId}/students")
                   ?? new List<TeacherStudentDto>();
        }

        // POST attendance
        public async Task<bool> SubmitAttendance(List<TeacherStudentDto> students)
        {
            var response = await _http.PostAsJsonAsync("api/teacher/attendance", students);
            return response.IsSuccessStatusCode;
        }
    }
}
