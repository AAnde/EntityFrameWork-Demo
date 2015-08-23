using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccess
{
    public static class EntityandDomainMapper
    {
        public static Employee ToEntity(this EmpDTO emp)
        {
            var employee = new Employee
            {
                Name = emp.Name,
                Salary = emp.Salary,
                JoinDate = emp.JoinDate,
                DepartmentID = emp.DepartmentID
            };
            return employee;
        }
        public static EmpDTO ToDomain(this Employee emp)
        {
            var employee = new EmpDTO
            {
                Name = emp.Name,
                Salary = emp.Salary,
                JoinDate = emp.JoinDate,
                DepartmentID = emp.DepartmentID
            };
            return employee;
        }
        public static Department ToEntity(this DeptDTO Dept)
        {
            var dept = new Department
            {
                Name=Dept.Name
            };
            return dept;
        }
        public static DeptDTO ToDomain(this Department Dept)
        {
            var dept = new DeptDTO
            {
                Name = Dept.Name
            };
            return dept;
        }

    }
}
