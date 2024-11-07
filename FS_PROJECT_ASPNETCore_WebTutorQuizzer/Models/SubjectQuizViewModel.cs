using Microsoft.AspNetCore.Mvc.Rendering;

namespace FS_PROJECT_ASPNETCore_WebTutorQuizzer.Models
{
    public class SubjectQuizViewModel
    {
        public List<QuizModel> Quizs  {  get; set; }
        public SelectList? Subjects { get;set; }
        public string? QuizSubject { get; set; }
        public string? SearchString { get; set; }
    }
}
