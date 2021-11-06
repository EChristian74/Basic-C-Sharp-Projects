using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodObjectInheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee();  //Inherits from the Person class via the Employee class
            employee.FirstName = "Sample";  //Instantiates string parameter FirstName in Person.cs 
            employee.LastName = "Student";  //Instantiates string parameter LastName in Person.cs
            employee.SayName();  //Calls the super class method SayName in Person.cs
            Console.ReadLine();  //Prints entire string "Name: Sample Student" to console

        }
    }
}
