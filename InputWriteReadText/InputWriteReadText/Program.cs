using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //"System.IO" required to write, read, append to a text file

namespace InputWriteReadText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a number: "); //Instruction to user to provide a number
            string entry = Console.ReadLine(); //Logs the user data entry
            int num = Convert.ToInt32(entry); //Casts string data entry to integer
            Console.ReadLine(); //Pauses and holds program open to run next section of program

            //StreamWriter object = path of log = "using" statement relates to utilization of a memory resource
            //Once the program hits the closing brace, the "using" statement enables the memory manager disposes of the resource
            using (StreamWriter file = new StreamWriter(@"C:\Users\timek\Desktop\Basic_C#_Programs\VideoTutorialSeries\TwentyOneGameProgram\Logs\log.txt", true))
            {
                //References the variable "entry" above
                file.WriteLine(entry);
            } //Once the program hits this closing brace, the memory manager disposes of the resource

            //String statement gathers all data written to the "log.txt" file | if the "@" symbol is not used, double backslashes are required
            string text = File.ReadAllText(@"C:\Users\timek\Desktop\Basic_C#_Programs\VideoTutorialSeries\TwentyOneGameProgram\Logs\log.txt");
            Console.WriteLine("The number you entered is: " + text); //Prints back to the user what number they entered
            Console.ReadLine(); //Holds open the console until the user executes "Return" or exits the console
        }
    }
}

