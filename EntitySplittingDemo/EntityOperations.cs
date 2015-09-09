using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySplittingDemo
{
    public class EntityOperations
    {
        #region EntitySplitting Operations
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
                var employee = context.Employees.FirstOrDefault(x => x.Id == emp.Id);
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
                var employee = context.Employees.FirstOrDefault(x => x.Id == empId);
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
        }
        #endregion
        #region TableSplitting Operations
        public List<EmployeeDetail> GetEmpTableSplit()
        {
            using (var context = new SampleDB1Entities())
            {
                List<EmployeeDetail> empDetails = context.EmployeeDetails.Include("EmployeeContactDetail").ToList();
                return empDetails;
            }
        }
        public void AddEmpTableSplit(EmployeeDetail empDetails)
        {
            using (var context = new SampleDB1Entities())
            {
                context.EmployeeDetails.Add(empDetails);
                context.SaveChanges();
            }
        }
        public void UpdateEmpTableSplit(EmployeeDetail empDetails)
        {
            using (var context = new SampleDB1Entities())
            {
                var emp = context.Employees.Include("EmployeeContactDetail").FirstOrDefault(x => x.Id == empDetails.Id);
                emp.Name = empDetails.Name;
                emp.Salary = empDetails.Salary;
                emp.DepartId = empDetails.DeptId;
               
            }
        }
        public void DeleteEmpTableSplit()
        {
            using (var context = new SampleDB1Entities())
            {

            }
        }
        #endregion
    }
}
