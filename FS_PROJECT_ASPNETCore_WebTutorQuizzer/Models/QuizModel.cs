using Microsoft.Identity.Client;

namespace FS_PROJECT_ASPNETCore_WebTutorQuizzer.Models
{
    public class QuizModel
    {

        public int Id { get; set; }

        public string Name { get; set; }    

        public bool IsDone { get; set; }    

        
        public List<EnumerationModel> Enumeration { get; set; }
        
        public List<MultipleModel> Multiple { get; set; }
        public DateTime DateTime { get; set; }
        public int SubjectId { get; set; }
        public SubjectModel Subject { get; set; }

    }
}
