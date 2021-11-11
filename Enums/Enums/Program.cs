using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Enums
{
    class Program
    {
        
        public enum EDay //Collection of enums for program
        {
            None,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)   
        {       

            Console.WriteLine("Please enter the current day of the week."); //Opening instruction to user
            string currentday = Console.ReadLine(); //User data entry
            EDay day; //Instantiates enum Eday

            try
            {
                //Scope for day = local
                day = (EDay)Enum.Parse(typeof(EDay), currentday); //Try statement to parse/validate data entry against + converts data type
            }
            catch (Exception ex) //Assignment of exception to a variable
            {
                //Scope for day = global
                day = EDay.None;
                Console.WriteLine("Please enter an actual day of the week."); //Instruction to user if data entry does not pass try pass
                Console.WriteLine(ex.Message); //Prints instruction to console to direct user to make another attempt
            }
            Console.ReadLine(); //Holds program open for next section of code to run 

            if (day == EDay.Wednesday) //Condition that states if the data entered by user is "Wednesday", condition is met
            {
                Console.WriteLine("Yes, today is Wednesday?"); //Prints acknowledgment to user that condition is met
            }
            else
            {
                Console.WriteLine("No, today is not Wednesday!"); //Prints acknowledgment to user that condition is not met
            }
            Console.ReadLine(); //Holds program open until user executes Return or exits console
        }
 
    }
}
