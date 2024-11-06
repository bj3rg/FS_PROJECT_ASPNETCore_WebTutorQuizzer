using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace FS_PROJECT_ASPNETCore_WebTutorQuizzer.Models
{
    public class QuizModel
    {
        public QuizModel()
        { 
            Enumeration = new List<EnumerationModel>();
            Multiple = new List<MultipleModel>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }    
        public bool IsDone { get; set; } 
        
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }
        [Required]
        public int SubjectId { get; set; }
        public SubjectModel Subject { get; set; }
        public ICollection<EnumerationModel> Enumeration { get; set; }
        public ICollection<MultipleModel> Multiple { get; set; }

    }
}
