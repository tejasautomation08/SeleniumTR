using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDashboard
{
    public class Employee
    {
        private int empID;
        public string empName;
        public double empSalary;
        private string empPerformance;
        public static string companyName;

        //Constructor

        public Employee()
        {
            Console.WriteLine("Object created");
        }


        public int EmpID
        {
            get
            {
                return empID;
            }
            set
            {
                if (value > 100)
                {
                    empID = value;
                }
                else
                {
                    Console.WriteLine("Please provide correct Employee ID, i.e. more than 100");
                }
            }
        }

        public string EmpPerf
        {
            get
            {
                return empPerformance;
            }
            set
            {
                if (value.Equals("A") || value.Equals("B") || value.Equals("C")) ;
                {
                    empPerformance = value;
                }
                {
                    Console.WriteLine("Performance value should be A, B or C");
                }
            }
        }
            public void DisplayEmployeeDetails()
        { 

            Console.WriteLine("Employee ID:" + empID);
            Console.WriteLine("Employee Name:" + empName);
            Console.WriteLine("Employee Salary:" + empSalary);
            Console.WriteLine("Employee Performance:" +empPerformance);
            Console.WriteLine("Company Name:" + Employee.companyName);
            Console.WriteLine("-------:");

        }

        public void AllocateBonus()
        {
            if (empPerformance != null)
            {
                if (empPerformance.Equals("A"))
                {
                    empSalary = empSalary + 1000;

                }
                else if (empPerformance.Equals("B"))
                {
                    empSalary = empSalary + 500;
                }
                else
                {
                    empSalary = empSalary + 100;
                }
            }
        }
    }
}
