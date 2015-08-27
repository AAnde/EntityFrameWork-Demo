using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class EmpRepository
    {
        public List<EmployeeNew> GetEmployeeNew()
        {
            using (var context = new TestDbContext())
            {
                List<EmployeeNew> emps = context.Employees.ToList();
                return emps;
            }
        }
    }
}
