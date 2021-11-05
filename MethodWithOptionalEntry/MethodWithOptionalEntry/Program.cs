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

            Option testObject = new Option();  //Creates variable that is used for all three methods
          

            Console.WriteLine("AGE DISCOUNT APPLICATION");  //Program Heading

            Console.WriteLine("Please enter the number of years driving for one or more drivers in your household:");  //Info line

            Console.WriteLine("Please enter the number of years driving for Driver 1: ");  //Instructs user to enter a number
            int x = Convert.ToInt32(Console.ReadLine());  //Program reads user data entry and sets entry data type
           

            Console.WriteLine("Please enter the number of years driving for Driver 2 (optional, \nenter zero if you do not wish to enter: ");  //Instructs user to enter a number
            string y = Console.ReadLine();  //Program reads user data entry and sets entry data type

            if (y == "")  //Condition if y is blank, execute the below
            {
                Console.WriteLine("The number of years on which we will base your discount is: " + testObject.Operation(x));  //Program will execute running only the x parameter of the method Option
                Console.ReadLine();  //Holds open console until user hits Return or exits the console
            }
            else  //Condition if y not blank, execute the below
            {
                int z = Convert.ToInt32(y);  //Casting of y from string to integer
                Console.WriteLine("The number of years on which we will base your discount is: " + testObject.Operation(x, z));  //Program will execute running both x and y of the method Option
            }

            Console.ReadLine();  //Holds open console until user hits Return or exits the console


            






        }
    }
}
