using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiCore.Models;

namespace WebApiCore.Interface
{
    public interface IEmployeeAngularRepository
    {
        Task<IEnumerable<EmployeeAngular>> GetEmployees();
        Task<EmployeeAngular> GetEmployeeByID(int ID);
        Task<EmployeeAngular> InsertEmployee(EmployeeAngular objEmployee);
        Task<EmployeeAngular> UpdateEmployee(EmployeeAngular objEmployee);
        bool DeleteEmployee(int ID);
    }
}

