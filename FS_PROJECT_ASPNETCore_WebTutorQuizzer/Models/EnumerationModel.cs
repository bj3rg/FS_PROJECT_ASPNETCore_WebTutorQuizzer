namespace FS_PROJECT_ASPNETCore_WebTutorQuizzer.Models
{
    public class EnumerationModel
    {
        public int Id { get; set; }

        public string Question { get; set; }

        public string CorrectAnswer { get; set; }

        public string Answer { get; set; }

        public int QuizId { get; set; }

        public QuizModel Quiz { get; set; }


    }
}
