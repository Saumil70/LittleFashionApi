using System.ComponentModel.DataAnnotations;

namespace LittleFashionApi.Model
{
    public class ProjectManager
    {
        [Key]
        public int ProjectManagerId { get; set; }
        public string ProjectManagerName { get; set; }
    }
}
