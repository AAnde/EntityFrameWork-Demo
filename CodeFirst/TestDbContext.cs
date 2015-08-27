using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace CodeFirst
{
    public class TestDbContext : DbContext
    {
        public DbSet<EmployeeNew> Employees { get; set; }
        public DbSet<DepartmentNew> Departments { get; set; }
    }
}
