using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class EmployeeNew
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? JoinDate { get; set; }
        public decimal? sal { get; set; }
        public int? DeptId { get; set; }

        public DepartmentNew DeapartmentNew { get; set; }

    }
}
