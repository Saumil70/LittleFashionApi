using LittleFashionApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LittleFashionApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        private readonly LittlefashionEntites _db;

        public EmployeeController(LittlefashionEntites db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult EmployeeData()
        {
           var EmployeeData = _db.Employees.Include(u=> u.Projects).Include(u=> u.ProjectManager).ToList();
            return Ok(EmployeeData);
        }

        [HttpGet("Search")]
        public IActionResult Search(string searchTerm)
        {
          
            if (!string.IsNullOrEmpty(searchTerm))
            {
                var searchedData = _db.Employees
                                      .Where(e => e.EmployeeName.Contains(searchTerm) ||
                                                  e.Projects.ProjectName.Contains(searchTerm) ||
                                                  e.ProjectManager.ProjectManagerName.Contains(searchTerm)).Include(u => u.Projects).Include(u => u.ProjectManager)
                                      .ToList();
                return Ok(searchedData);
            }
            else
            {
             
                var allEmployees = _db.Employees.ToList();
                return Ok(allEmployees);
            }
        }


        [HttpGet("Filter")]
        public IActionResult Filter(string filterTerm)
        {
            if (!string.IsNullOrEmpty(filterTerm))
            {
                // Filter employees based on the project name
                var filteredData = _db.Employees
                                      .Where(e => e.Projects.ProjectName.Equals(filterTerm))
                                      .Include(u => u.Projects)
                                      .Include(u => u.ProjectManager)
                                      .ToList();
                return Ok(filteredData);
            }
            else
            {
                // Return all employees if no filter term is provided
                var allEmployees = _db.Employees
                                      .Include(u => u.Projects)
                                      .Include(u => u.ProjectManager)
                                      .ToList();
                return Ok(allEmployees);
            }
        }

        [HttpGet("GetProjects")]
        public IActionResult GetProjects()
        {
            var ProjectData = _db.Projects.ToList(); ;
            return Ok(ProjectData);
        }

        [HttpGet("GetEmployeeById")]
        public IActionResult GetEmployeeById(int employeeId)
        {
            var employeeData = _db.Employees.Where(u=> u.EmployeeId == employeeId).Include(u=> u.Projects).Include(u=> u.ProjectManager);
            return Ok(employeeData);
        }

    }
}
