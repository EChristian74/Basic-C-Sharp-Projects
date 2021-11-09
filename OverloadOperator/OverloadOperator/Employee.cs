using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperator
{
    public class Employee //Class Employee
    {
        public int EmployeeID { get; set; }  //Creates property employeeID
        public string EmployeeName { get; set; }  //Creates property firstName

        //Overload operator method using equals to compare employee ID's
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            //Condition that tests if ID's are equal
            if (employee1.EmployeeID.Equals(employee2.EmployeeID)) 
            {
                return true; //return statement returns true if condition met (Equals)
            }
            else
            {
                return false; //return statement returns false if condition not met (Equals)
            }
        }

        //Overload operator method using does not equal to compare employee ID's
        public static bool operator !=(Employee employee1, Employee employee2) 
        {
            if (!employee1.EmployeeID.Equals(employee2.EmployeeID))
            {
                return false; //return statement returns false if condition met (Does Not Equal)
            }
            else
            {
                return true; //return statement returns true if condition not met (Does Not Equal)
            }
        }

    }
    }
