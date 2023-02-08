using Microsoft.EntityFrameworkCore;
using ORMExplained.Server.Data;
using ORMExplained.Shared;

namespace ORMExplained.Server.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext appDbContext;

        public EmployeeRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            var employees = await appDbContext.Employees.ToListAsync();
            return employees;
        }
    }
}
