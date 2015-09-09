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
        public static EntitySplittingDemo.EntityOperations splitObj = new EntitySplittingDemo.EntityOperations(); 
        #region Main
        static void Main(string[] args)
        {
            Console.WriteLine("Main started...");
            try
            {
                //Console.WriteLine("Enter Id to delete a record...");
                //int id = Convert.ToInt32(Console.ReadLine());
                //AddEmployee();
                //UpdateEmployee();
                //GetEmployees();
                //GetDepts();
                //DeleteEmp();
                ////GetEmp();
                AddEmpsTableSplit();
                Console.WriteLine("Success");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
        #endregion
        #region Schema First
        #region EmpOperations
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
                obj.AddEmployee_sp(emp);
                Console.WriteLine("Added succesfully....");
                //Console.WriteLine(Id);
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
        #endregion
        #region DeptOperations
        private static void GetDepts()
        {
            List<Department> Departments = obj.GetDepts();
            foreach (Department dept in Departments)
            {
                Console.WriteLine(string.Format("Department:{0}", dept.Name));
                Console.WriteLine("Employees :");

                foreach (Employee emp in dept.Employees)
                {
                    Console.WriteLine(string.Format("Name:{0}", emp.Name));
                }
            }
        }
        #endregion
        #endregion
        #region EntitySplitting
        private static void GetEmp()
        {
            List<EntitySplittingDemo.Employee> emps = splitObj.GetEmployees();
            foreach (EntitySplittingDemo.Employee employee in emps)
            {
                Console.WriteLine(employee.Name);
            }
        }
        private static void AddEmp()
        {
            EntitySplittingDemo.Employee emp = new EntitySplittingDemo.Employee()
            {
                Id=2,
                Name = "Bhaskar",
                Salary = 10000,
                MobileNo = "9885855600",
                Location = "Hyderabad"
            };
            splitObj.AddEmployee(emp);
        }
        private static void UpdateEmp()
        {
            EntitySplittingDemo.Employee emp = new EntitySplittingDemo.Employee()
            {
                Id = 2,
                Name = "Bhaskarr",
                Salary = 20000,
                MobileNo = "9885855600",
                Location = "Hyderabadd"
            };
            splitObj.UpdateEmpolyee(emp);
        }
        private static void DeleteEmp()
        {
            splitObj.DeleteEmployee(2);
        }
        #endregion
        #region TableSplitting
        static void GetEmpsforTableSplit()
        {
            List<EntitySplittingDemo.EmployeeDetail> empDetails = splitObj.GetEmpTableSplit();
            if(empDetails.Count !=0)
            {

            }
        }
        static void AddEmpsTableSplit()
        {
            EntitySplittingDemo.EmployeeDetail empDetails = new EntitySplittingDemo.EmployeeDetail()
            {
                Name="ashok",Salary=15000
            };
            empDetails.EmployeeContactDetail = new EntitySplittingDemo.EmployeeContactDetails()
            {
                MobileNo = "9550937878",
                Location = "Hyderabad"
            };
            splitObj.AddEmpTableSplit(empDetails);
        }
        #endregion
    }
}
