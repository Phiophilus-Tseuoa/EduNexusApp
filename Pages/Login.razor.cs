using Microsoft.AspNetCore.Components;
using DemoMVP.Services;

namespace DemoMVP.Pages
{
    public class LoginBase : ComponentBase
    {
        [Inject] NavigationManager Nav { get; set; } = default!;
        [Inject] TeacherDataService TeacherData { get; set; } = default!;
        [Inject] StudentService StudentData { get; set; } = default!;

        protected string Email { get; set; } = "";
        protected string Password { get; set; } = ""; // not used yet
        protected string ErrorMessage { get; set; } = "";

        protected void HandleLogin()
        {
            var teacher = TeacherData.GetTeacherByEmail(Email);
            if (teacher != null)
            {
                Nav.NavigateTo("/teacher-dashboard");
                return;
            }

            var student = StudentData.GetStudentByEmail(Email);
            if (student != null)
            {
                Nav.NavigateTo("/student-dashboard");
                return;
            }

            ErrorMessage = "Invalid email. User not found.";
        }
    }
}
