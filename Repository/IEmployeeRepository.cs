using ORMExplained.Shared;

namespace ORMExplained.Server.Repository
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllEmployees();
    }
}
