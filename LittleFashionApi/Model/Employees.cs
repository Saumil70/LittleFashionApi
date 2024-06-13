using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LittleFashionApi.Model
{
    public class Employees
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        // Foreign key for Projects
        public int ProjectId { get; set; }

        [ForeignKey("ProjectId")]
        public Projects Projects { get; set; }

        // Foreign key for ProjectManager
        public int ProjectManagerId { get; set; }

        [ForeignKey("ProjectManagerId")]
        public ProjectManager ProjectManager { get; set; }
    }
}
