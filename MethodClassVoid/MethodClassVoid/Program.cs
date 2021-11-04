using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassVoid
{
    class Program  //Main program
    {
        static void Main(string[] args)
        {
            var Object = new Method();  //Creates object that is used by the class Method of the same name

            Console.WriteLine("Please enter an integer: ");  //Instructs user to enter a number
            int a = Convert.ToInt32(Console.ReadLine());  //Program reads user data entry and sets entry data type
       
            Console.ReadLine();  //Blank line

            Console.WriteLine("Please enter another integer: ");  //Instructs user to enter a number
            int b = Convert.ToInt32(Console.ReadLine());  //Program reads user data entry and sets entry data type

            Console.ReadLine();  //Blank line

            Console.WriteLine("Your discount totals: ");  //Prints only the result of parameter "b" in Method.cs
            Object.Operation(a, b);

            Console.ReadLine();  //Holds open console until user hits Return or exits the console

        }
    }
}
