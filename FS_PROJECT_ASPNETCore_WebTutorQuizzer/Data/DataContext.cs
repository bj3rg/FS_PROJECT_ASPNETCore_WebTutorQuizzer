using FS_PROJECT_ASPNETCore_WebTutorQuizzer.Models;
using Microsoft.EntityFrameworkCore;

namespace FS_PROJECT_ASPNETCore_WebTutorQuizzer.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options) { }
        public DbSet<QuizModel> Quiz { get; set; }
        public DbSet<SubjectModel> Subject { get; set; }
        public DbSet<EnumerationModel> Enumeration { get; set; }
        public DbSet<MultipleModel> Multiple { get; set; }
    }
}
