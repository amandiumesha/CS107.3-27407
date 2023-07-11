using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical04.Q1
{
    internal class Employee
    {
        private int employeeID;
        private string employeeName;
        private string employeeDesignation;

        
        public int empID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

     
        public string empName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        
        public string empDesignation
        {
            get { return employeeDesignation; }
            set { employeeDesignation = value; }
        }

    }
}