using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySplittingDemo
{
    public class EntityOperations
    {
        public List<Employee> GetEmployees()
        {
            using (var context = new SampleDB1Entities())
           {
               List<Employee> emps = context.Employees.ToList();
               return emps;
           }
        }
        public void AddEmployee(Employee emp)
        {
            using (var context = new SampleDB1Entities())
            {
                context.Employees.Add(emp);
                context.SaveChanges();
            }
        }
        public void UpdateEmpolyee(Employee emp)
        {
            using (var context = new SampleDB1Entities())
            {
                var employee = context.Employees.FirstOrDefault(x=>x.Id == emp.Id);
                employee.Name = emp.Name;
                employee.Salary = emp.Salary;
                employee.Location = emp.Location;
                employee.MobileNo = emp.MobileNo;
                employee.DepartId = emp.DepartId;
                context.SaveChanges();
            }
        }
        public void DeleteEmployee(int empId)
        {
            using (var context = new SampleDB1Entities())
            {
                var employee = context.Employees.FirstOrDefault(x=>x.Id == empId);
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
        }
    }
}
