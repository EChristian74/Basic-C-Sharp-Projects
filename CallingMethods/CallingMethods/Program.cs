using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        public static int Data { get; set; }
        static void Main(string[] args)
        {
            //heading of program - displays to console
            Console.WriteLine("ADD, SUBTRACT, MULTIPLY, DIVIDE");

            //instruction to user to enter a number to perform math operations
            Console.WriteLine("Please enter a number: ");
            string userEntry = Console.ReadLine();  //program reads user data entry
            Data = Convert.ToInt32(userEntry);  //casting, boolean to string

            var operatorObject1 = new Operators();  //instantiates new variable operatorObject1  
            var result1 = operatorObject1.GetAdd(Data);  //calls method GetAdd

            var operatorObject2 = new Operators();  //instantiates new variable operatorObject2 
            var result2 = operatorObject2.GetSubtract(Data);  //calls method GetSubtract

            var operatorObject3 = new Operators();  //instantiates new variable operatorObject3 
            var result3 = operatorObject3.GetMultiply(Data);  //calls method GetMultiply

            var operatorObject4 = new Operators();  //instantiates new variable operatorObject4 
            var result4 = operatorObject4.GetDivide(Data);  //calls method GetDivide

            Console.WriteLine("Your number plus 5 equals " + result1);  //Writes result1 to console
            Console.WriteLine("Your number minus 5 equals " + result2);  //Writes result2 to console
            Console.WriteLine("Your number multiplied by 5 equals " + result3);  //Writes result3 to console
            Console.WriteLine("Your number divided by 5 equals " + result4);  //Writes result4 to console

            Console.ReadLine();  //pauses and holds open console until user hits Return or exits console
        }
    }
}

