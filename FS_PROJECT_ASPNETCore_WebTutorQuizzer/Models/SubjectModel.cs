namespace FS_PROJECT_ASPNETCore_WebTutorQuizzer.Models
{
    public class SubjectModel
    {
        public SubjectModel()
        {
            Quizzes = new List<QuizModel>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<QuizModel> Quizzes { get; set; }


    }
}
