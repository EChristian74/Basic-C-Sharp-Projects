using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidOverloadStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //VOID METHOD THAT OUTPUTS AN INTEGER FROM "Method 1"
            Method1 Object1 = new Method1();  //Object for Method1.cs
            Method3 Object3 = new Method3();  //Object for Method2.cs

            //Method1.cs method Operation
            Console.WriteLine("Please enter a number: ");  //Instructs user to enter a number
            int x = Convert.ToInt32(Console.ReadLine());  //Program reads user data entry and sets entry data type
            Object1.Operation(x);  //Calls the first method "Operation" in Method1.cs
            Console.ReadLine();  //Prints output to console

            //Method1.cs method Operation (overload)
            Console.WriteLine("Please provide your favorite color: ");  //Instructs user to enter a number
            string c = Convert.ToString(Console.ReadLine());  //Program reads user data entry and sets entry data type
            Console.WriteLine("Please provide your favorite shape: ");  //Instructs user to enter a number
            string s = Convert.ToString(Console.ReadLine());  //Program reads user data entry and sets entry data type
            Object1.Operation(c, s);  //Calls the overload method "Operation" in Method1.cs
            Console.ReadLine();  //Prints output to console


            //CALLS CALCULATOR RESULT FOR STATIC METHOD (Method2.cs)
            var result = Calculator.Sum(10, 25); // Calls the static method, 
            Calculator.Store(result);  //Stores the sum result
            Console.WriteLine("10 plus 25 equals: " + result);  //Prints the sum result to the console

            Console.ReadLine();  //Blank line


            //CALLS METHOD WITH AN OUTPUT PARAMETER (Method3.cs)
            int a = 50;  //Creates variable a and assigns a value of 50 prior to calling of the method
            Console.WriteLine("Value before calling: " + a);  //Calls the value of "int a" before the method is calls - 50 does not interact with method
            Object3.Display(out a);  //Calls the method operation result from the method OutMethod in Method3.cs and prints to console
            Console.WriteLine("Value after calling: " + a);  //Prints the same value that resulted from the method operation


            Console.ReadLine();  //Pauses and holds the program open until the user keys Return or exits the console
            





        }
    }
}
