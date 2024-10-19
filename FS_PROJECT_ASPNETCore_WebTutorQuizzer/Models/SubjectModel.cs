namespace FS_PROJECT_ASPNETCore_WebTutorQuizzer.Models
{
    public class SubjectModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<QuizModel> Quizzes { get; set; }


    }
}
