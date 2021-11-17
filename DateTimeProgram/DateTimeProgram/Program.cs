using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var dateAndTime = DateTime.Now; //Creates new DateTime.Now object
            Console.WriteLine("The date and time right now is: " + dateAndTime); //Current date and time statement
            Console.ReadLine(); //Prints the current date and time statement to console

            Console.WriteLine("Dear User, please provide a number of your choosing: ");  //Prints user instruction to console
            string entry = Console.ReadLine();  //User data entry
            double num = Convert.ToDouble(entry);  //Cast of user data entry from casting string to double
            var newTime = DateTime.Now.AddHours(num); //Creates new variable for DateTime.Now of "newTime" + adds user data entry to DateTime.Now

            Console.ReadLine(); //Blank Line

            Console.WriteLine("The current date and time, plus user entry is " + newTime); //Prints current date and time + user data entry to console
            Console.ReadLine(); //Holds open console unti use executes Return or exits the console

        }
    }
}
