namespace FS_PROJECT_ASPNETCore_WebTutorQuizzer.Models
{
    public class MultipleModel
    {

        public int Id { get; set; }

        public string Question  { get; set; }

        public string CorrectAnswer {  get; set; }
        public string Choice1 { get; set; }
        public string Choice2 { get; set; }
        public string Choice3 { get; set; }
        public string Choice4 { get; set; }

        public int QuizId {  get; set; }

        public QuizModel Quiz { get; set; }
    }
}
