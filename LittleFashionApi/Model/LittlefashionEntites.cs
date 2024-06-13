using Microsoft.EntityFrameworkCore;

namespace LittleFashionApi.Model
{
    public class LittlefashionEntites : DbContext
    {
        public LittlefashionEntites(DbContextOptions<LittlefashionEntites> options): base(options)
        {
        }

        public DbSet<Cards> Cards { get; set; } 
        public DbSet<Employees> Employees { get; set; }
        public DbSet<ProjectManager> ProjectManagers { get; set; }
        public DbSet<Projects> Projects { get; set; }   
    }
}
