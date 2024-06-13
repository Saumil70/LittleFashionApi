using System.ComponentModel.DataAnnotations;

namespace LittleFashionApi.Model
{
    public class Projects
    {
        [Key]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; } 
    }
}
