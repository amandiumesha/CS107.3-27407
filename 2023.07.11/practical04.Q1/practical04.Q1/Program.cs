using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical04.Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            
            Console.Write("Enter Employee ID: ");
            int empID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            string empName = Console.ReadLine();

            Console.Write("Enter Employee Designation: ");
            string empDesignation = Console.ReadLine();

          
            employee.empID = empID;
            employee.empName = empName;
            employee.empDesignation = empDesignation;

           
            int retrievedEmpID = employee.empID;
            string retrievedEmpName = employee.empName;

          
            Console.WriteLine("Hello, {0}! Your Employee ID is {1} and you are a {2}.", retrievedEmpName, retrievedEmpID, employee.empDesignation);
            Console.ReadLine();

        }
    }
    }

