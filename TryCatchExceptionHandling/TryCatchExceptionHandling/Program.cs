using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchExceptionHandling
{
    class Program
    {
        private static void Main(string[] args)
        {
            
            int age = 0; //Assigns to age a variable with a default value of "0"
            const int V = 2021; //Creates a const (immutable) variable for the current year

            try
            {
                //Instruction to user to provide current age
                Console.WriteLine("Please provide your current age."); 
                //Casts string "age" to its 32-bit assigned integer value
                age = int.Parse(Console.ReadLine()); 

                //Condition to validate age is not "0" or less than "0" (negative)
                if (age <= 0) 
                {
                    //If condition not met, this message is printed to the console
                    Console.WriteLine("Please enter only an age above zero and is not negative.");
                }
                else //If condition met, this message is printed to the console
                {
                    //If condition met, the first statement calculates the year the user was born
                    Console.WriteLine("Based on your age, you were born in the year " + (V - age));
                    //This statement simply thanks the user for their time
                    Console.WriteLine("Thank you, and have a good day!");
                    //Holds console open until user exectute "Return" or exits the console entirely
                    Console.ReadLine(); 
                }                
            }
            catch (Exception) //Generic, built-in exception
            {
                //The statement is executed if the user was to perform some other more general error
                //Example: Some completely random string that does not meet the condition in the "if" statement
                Console.WriteLine("An error has occurred, please contact an administrator.");
                Console.ReadLine();
            }
            //Holds open console until user executes "Return" or exits the console entirely
            Console.ReadLine();
        }
    }
}
