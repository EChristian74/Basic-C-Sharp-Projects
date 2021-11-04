using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodWithOptionalEntry
{
    class Program
    {
        static void Main(string[] args)
        {

            var testObject = new Method();  //Creates variable that is used for all three methods

            //int discount = (int).02;

            Console.WriteLine("AGE DISCOUNT APPLICATION");  //Program Heading

            Console.WriteLine("Please enter the number of years driving for one or more drivers in your household:");  //Info line

            Console.WriteLine("Please enter the number of years driving for Driver 1: ");  //Instructs user to enter a number
            int x = Convert.ToInt32(Console.ReadLine());  //Program reads user data entry and sets entry data type
            int result1 = testObject.Optional(x);  //Calls method Optional

            Console.ReadLine();  //Blank line

            Console.WriteLine("Please enter the number of years driving for Driver 2 (optional, \nenter zero if you do not wish to enter: ");  //Instructs user to enter a number
            int y = Convert.ToInt32(Console.ReadLine());  //Program reads user data entry and sets entry data type
            int result2 = testObject.Optional(y);  //Calls method Optional

            Console.ReadLine();  //Blank line

            Console.WriteLine("The number of years on which we will base your discount is: ");  //Prints final communication statement to console

            Console.WriteLine(testObject.Optional(x, y));  //Prints final match operation result to the console

            Console.ReadLine();  //Holds open console until user hits Return or exits the console









        }
    }
}
