using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccess
{
    public class EmployeeOperations
    {
        public int AddEmployee(EmpDTO Emp)
        {
            using (var empEntities = new EmployeeDBEntities())
            {
                var employee = Emp.ToEntity();
                empEntities.Employees.Add(employee);
                empEntities.SaveChanges();
                return employee.ID;
            }
        }
        public void UpdateEmployee(EmpDTO Emp)
        {
            using (var empEntities = new EmployeeDBEntities())
            {
                var employee = empEntities.Employees.FirstOrDefault(x => x.ID == Emp.ID);
                employee.JoinDate = Emp.JoinDate;
                employee.Name = Emp.Name;
                employee.Salary = Emp.Salary;
                employee.DepartmentID = Emp.DepartmentID;
                empEntities.SaveChanges();
            }
        }
        public void DeleteEmployee(int EmpId)
        {
            using (var empEntities = new EmployeeDBEntities())
            {
                var employee = empEntities.Employees.FirstOrDefault(x => x.ID == EmpId);
                empEntities.Employees.Remove(employee);
                empEntities.SaveChanges();
            }
        }
        public List<Employee> GetEmployees()
        {   
            using(var empEntities = new EmployeeDBEntities())
            {
             List<Employee> employees = empEntities.Employees.ToList();
             return employees;
            }
        }
        public List<Department> GetDepts()
        {
            using (var empEntities = new EmployeeDBEntities())
            {
                List<Department> depts = empEntities.Departments.Include("Employees").ToList();
                return depts;
            }
        }

        public void AddEmployee_sp(EmpDTO Emp)
        {
            using (var empEntities = new EmployeeDBEntities())
            {
                var employee = Emp.ToEntity();
                empEntities.spAddEmployee(employee.Name,employee.JoinDate,employee.Salary,employee.DepartmentID);                                                                                                                                                                                                                                                                                                                                              
            }
        }
        public void UpdateEmployee_sp(EmpDTO Emp)
        {
            using (var empEntities = new EmployeeDBEntities())
            {
                var employee = empEntities.Employees.FirstOrDefault(x => x.ID == Emp.ID);
                employee.JoinDate = Emp.JoinDate;
                employee.Name = Emp.Name;
                employee.Salary = Emp.Salary;
                employee.DepartmentID = Emp.DepartmentID;
                empEntities.SaveChanges();
            }
        }
        public void DeleteEmployee_sp(int EmpId)
        {
            using (var empEntities = new EmployeeDBEntities())
            {
                var employee = empEntities.Employees.FirstOrDefault(x => x.ID == EmpId);
                empEntities.Employees.Remove(employee);
                empEntities.SaveChanges();
            }
        }

    }
}
