using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConstructorConstantVariable
{
    class Programs
    {

        static void Main(string[] args)
        {
           
            const string greeting = "Welcome new employee!";  //Const keyword string greeting
            Console.WriteLine(greeting); //Writes greeting to console

            Console.WriteLine("Please type in your first name."); //Instruction to user to provide first name
            string name = Console.ReadLine(); //Declares variable of name and reads user input

            var newEmployee = new NewEmployee(name); //Object for calling of NewEmployee class/method
            Console.WriteLine("Welcome {0} {1}", newEmployee.firstName, newEmployee.lastName); //Message that incorporates string method to call NewEmployee parameters
            Console.ReadLine(); //Holds open console until user executes the Return key or exits the console

        }
    }
}


