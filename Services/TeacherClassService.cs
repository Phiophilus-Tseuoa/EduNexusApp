namespace DemoMVP.Services
{
    public class TeacherClassService
    {
        public List<string> UploadedSlides { get; set; } = new();
        public List<(string Question, List<string> Options)> Quizzes { get; set; } = new();
        public List<(string Student, string Answer)> Responses { get; set; } = new();

        public void AddSlide(string slideName)
        {
            UploadedSlides.Add(slideName);
        }

        public void AddQuiz(string question, List<string> options)
        {
            Quizzes.Add((question, options));
        }

        public void AddResponse(string student, string answer)
        {
            Responses.Add((student, answer));
        }
    }
}
