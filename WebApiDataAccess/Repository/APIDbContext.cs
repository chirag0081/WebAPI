using Microsoft.EntityFrameworkCore;
using WebApiCore.Models;

namespace WebApiDataAccess.Repository
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options)
        {

        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeAngular> EmployeeAngulars { get; set; }

    }
}
