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

            Employee quit = new Employee();  //Inherits from the IQuittable class via the Employee class
            employee.Quit();  //Calls the interface class method Quit in Iquittable.cs
            Console.ReadLine();  //Prints the string from Quit to console

        }
    }
}
