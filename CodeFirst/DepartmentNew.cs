using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class DepartmentNew
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<EmployeeNew> Employees { get; set; }
    }
}
