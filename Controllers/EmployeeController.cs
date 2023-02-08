using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ORMExplained.Server.Repository;
using ORMExplained.Shared;

namespace ORMExplained.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> GetEmployees()
        {
            var employees = await employeeRepository.GetAllEmployees();
            return Ok(employees);
        }
    }
}
