using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EmpDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> JoinDate { get; set; }
        public Nullable<int> Salary { get; set; }
        public Nullable<int> DepartmentID { get; set; }
    }
}
