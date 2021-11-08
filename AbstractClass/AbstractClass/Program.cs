using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();  //Inherits from the Person class via the Employee class
            employee.firstName = "Sample";  //Instantiates string parameter FirstName in Person.cs 
            employee.lastName = "Student";  //Instantiates string parameter LastName in Person.cs
            employee.SayName();  //Calls the super class method SayName in Person.cs
            Console.ReadLine();  //Prints entire string "Sample Student" to console
            
            IQuittable quit = new Employee();  //Creates object to instantiate interface Quit method via Employee class inheritance  
            quit.Quit();  //Calls Quit method

            Console.ReadLine();  //Prints the string from Quit to console via the Employee class

        }
    }
}
