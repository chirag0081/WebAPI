using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiCore.Models;
using WebApiCore.Interface;

namespace WebApiDataAccess.Repository
{


    public class EmployeeAngularRepository : IEmployeeAngularRepository
    {
        private readonly APIDbContext _appDBContext;

        public EmployeeAngularRepository(APIDbContext context)
        {
            _appDBContext = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<EmployeeAngular>> GetEmployees()
        {
            return await _appDBContext.EmployeeAngulars.ToListAsync();
        }

        public async Task<EmployeeAngular> GetEmployeeByID(int ID)
        {
            return await _appDBContext.EmployeeAngulars.FindAsync(ID);
        }

        public async Task<EmployeeAngular> InsertEmployee(EmployeeAngular objEmployee)
        {
            _appDBContext.EmployeeAngulars.Add(objEmployee);
            await _appDBContext.SaveChangesAsync();
            return objEmployee;
        }

        public async Task<EmployeeAngular> UpdateEmployee(EmployeeAngular objEmployee)
        {
            _appDBContext.Entry(objEmployee).State = EntityState.Modified;
            await _appDBContext.SaveChangesAsync();
            return objEmployee;
        }

        public bool DeleteEmployee(int ID)
        {
            bool result = false;
            var department = _appDBContext.EmployeeAngulars.Find(ID);
            if (department != null)
            {
                _appDBContext.Entry(department).State = EntityState.Deleted;
                _appDBContext.SaveChanges();
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

       
    }
}

