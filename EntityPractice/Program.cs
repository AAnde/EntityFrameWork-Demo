using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DataAccess;

namespace EntityPractice
{
    class Program
    {
        public static EmployeeOperations obj = new EmployeeOperations();

        static void Main(string[] args)
        {
            Console.WriteLine("Main started...");
            //Console.WriteLine("Enter Id to delete a record...");
            //int id = Convert.ToInt32(Console.ReadLine());
            //AddEmployee();
            //UpdateEmployee();
            GetEmployees();
            GetDepts();
            Console.ReadLine();
        }
        private static void AddEmployee()
        {
            try
            {
                var emp = new EmpDTO
                {
                    Name = "as",
                    Salary = 20000,
                    JoinDate = Convert.ToDateTime("04-05-1989"),
                    DepartmentID = 2
                };
                int Id = obj.AddEmployee(emp);
                Console.WriteLine("Added succesfully....");
                Console.WriteLine(Id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
        private static void DeleteEmployee(int id)
        {
            obj.DeleteEmployee(id);
            Console.WriteLine("Deleted succesfully....");
        }

        private static void UpdateEmployee()
        {
            try
            {
                var emp = new EmpDTO
                {
                    ID = 1004,
                    Name = "as",
                    Salary = 20000,
                    JoinDate = Convert.ToDateTime("04-05-1989"),
                    DepartmentID = 2
                };
                obj.UpdateEmployee(emp);
                Console.WriteLine("Updated succesfully....");
                Console.WriteLine(emp.ID);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private static void GetEmployees()
        {
            List<Employee> employees = obj.GetEmployees();
            foreach (Employee emp in employees)
            {
                Console.WriteLine(string.Format("Name:{0},Salary:{1},JoinDate:{2}", emp.Name, emp.Salary, emp.JoinDate));
            }
        }

        private static void GetDepts()
        {
            List<Department> Departments = obj.GetDepts();
            foreach (Department dept in Departments)
            {
                Console.WriteLine(string.Format("Department:{0}", dept.Name));
            }
        }
    }
}
