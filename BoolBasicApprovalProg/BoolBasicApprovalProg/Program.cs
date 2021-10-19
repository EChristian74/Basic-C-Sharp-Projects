using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolBasicApprovalProg
{
    class Program : ProgramBase
    {
        //Employed utilization of what are known as "constants" to esablish unchanging qualification conditions
        public const int V = 15;
        public const bool Z = false;
        public const int X = 3;
        public static bool result;

        static void Main(string[] args)
        {

            //Basic insurance approval form greeting and introduction
            Console.WriteLine("Welcome to Acme Car Insurance. \nYou will be asked a few questions to determine if you qualify. \n");

            Console.WriteLine("What is your age?");  //First qualifying question = age
            string ageResponse = Console.ReadLine();  //data entry
            int age = Convert.ToInt32(ageResponse);  //casting string to int
            Console.ReadLine();  //pauses and holds program open to run next section of program

            Console.WriteLine("Have you ever had a DUI? \nPlease enter true or false.");  //First qualifying question = DUI
            string DUIResponse = Console.ReadLine();  //data entry
            bool DUI = Convert.ToBoolean(DUIResponse);  //casting string to bool
            Console.ReadLine();  //pauses and holds program open to run next section of program

            Console.WriteLine("How many speeding tickets do you have?");   //First qualifying question = speeding tickets
            string speedResponse = Console.ReadLine();  //data entry
            int speed = Convert.ToInt32(speedResponse);  //casting string to int
            Console.ReadLine();  //pauses and holds program open to run next section of program

            Console.WriteLine("Qualified?");   //Qualification form results notification
            result = age > V && DUI == Z && speed <= X;  //Executes multi-factor boolean comparison of qualification constants vs. user entry    
            Console.WriteLine(result);  //prints qualification result to console
            Console.ReadLine();  //pauses and holds program open

        }
    }

}
