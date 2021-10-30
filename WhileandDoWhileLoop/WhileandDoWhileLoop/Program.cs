using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileandDoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            ////While loop quiz asking of the top five favorite lucky number that people choose, which is #1
            //Console.WriteLine("Out of the top 3 numbers people consider to be lucky, which is #1?");  //question one, prints to console
            //int fnumber = Convert.ToInt32(Console.ReadLine());  //user data entry - guess lucky number
            //bool guess1 = fnumber == 32;  //Comparison condition to compare against user data entry

            ////While loop using switch statement
            //while (!guess1)
            //{
            //    switch (fnumber)  //Switch statement that iterates through multiple choices for this quiz
            //    {
            //        case 3:  //one of three multiple choices
            //            Console.WriteLine("You guessed 3. Try again.");  //prints to console
            //            Console.Write("Guess another number?");  //prints to console
            //            fnumber = Convert.ToInt32(Console.ReadLine());  //user data entry
            //            break;  //break if condition occurs
            //        case 8:  //two of three multiple choices
            //            Console.WriteLine("You guessed 8. Try again.");  //prints to console
            //            Console.Write("Guess another number?");  //prints to console
            //            fnumber = Convert.ToInt32(Console.ReadLine());  //user data entry
            //            break;  //break if condition occurs
            //        case 7:  //three of three multiple choices, the correct choice
            //            Console.WriteLine("You guessed the number 7. That is correct!");  //prints to console if true
            //            guess1 = true;
            //            break;  //break if condition occurs
            //        default:
            //            Console.WriteLine("That number is not in the top 3!");  //prints to console
            //            Console.Write("Guess another lucky number?");  //prints to console
            //            fnumber = Convert.ToInt32(Console.ReadLine());  //user data entry
            //            break;  //break if condition occurs
            //    }
            //}
            //Console.ReadLine();  //pauses and holds program open for next section of program to run



            //Do-while loop using switch statement
            Console.WriteLine("Out of the top 3 number that are most lucky for the Powerball lottery, which is the most lucky?");  //question two, prints to console
            int lnumber = Convert.ToInt32(Console.ReadLine());  //user data entry - lucky number guess attempt
            bool guess2 = lnumber == 23;  //Comparison condition to compare against user data entry

            do
            {
                switch (lnumber)  //Switch statement that iterates through multiple choices for this quiz
                {
                    case 32:  //one of three multiple choices
                        Console.WriteLine("You guessed 32. Try again.");  //prints to console
                        Console.Write("Guess another lottery number?");  //prints to console
                        lnumber = Convert.ToInt32(Console.ReadLine());  //user data entry
                        break;  //break if condition occurs
                    case 61:  //two of three multiple choices
                        Console.WriteLine("You guessed 61. Try again.");  //prints to console
                        Console.Write("Guess another lottery number?");  //prints to console
                        lnumber = Convert.ToInt32(Console.ReadLine());  //user data entry
                        break;  //break if condition occurs
                    case 23:  //three of three multiple choices, the correct choice
                        Console.WriteLine("You guessed the number 23. That is the most lucky Powerball number!");
                        guess2 = true;  
                        break;  //break if condition occurs
                    default:
                        Console.WriteLine("You are wrong!");  //prints to console
                        Console.Write("That number is not in the top 3!");  //prints to console
                        lnumber = Convert.ToInt32(Console.ReadLine());  //user data entry
                        break;  //break if condition occurs
                }
            }

            while (!guess2);

            Console.Read();  //pauses and holds program open until user hits return or exits the console
        }
    }
}

