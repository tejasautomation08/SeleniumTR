using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDashboard
{
    public class EmployeeRunner
    {
        public static void Main(string[] args)

        {
        Employee.companyName = "TR";

        Employee emp1= new Employee();
        Employee emp2= new Employee();
        Employee emp3 = new Employee();


            emp1.EmpID = 101;
            emp1.empName = "Walter white";
            emp1.empSalary = 20000;
            emp1.EmpPerf = "B";

            emp2.EmpID = 102;
            emp2.empName = "Jesse Pinkman";
            emp2.empSalary = 30000;
            emp2.EmpPerf = "A";

            emp1.DisplayEmployeeDetails();
            emp2.DisplayEmployeeDetails();

            emp1.AllocateBonus();


        }
    }
}

