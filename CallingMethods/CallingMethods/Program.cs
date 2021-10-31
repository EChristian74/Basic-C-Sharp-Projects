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
            Console.WriteLine("PLUS, MINUS, DIVIDE!");  

            //instruction to user to enter a number to perform math operations
            Console.WriteLine("Please enter a number that will be used \nto add, subtract, multiply, and divide:");
            string line = Console.ReadLine();  //program reads user data entry
            Data = Int32.Parse(line);  //converts string representation of a number to its 32-bit signed integer equivalent

            var operatorObject = new Operator();  //instantiates new variable operatorObject  
            var result = operatorObject.GetAdd(Data);  //calls on the class of Operator in Operator.cs file

            Console.WriteLine(result);  //displays
            Console.ReadLine();  //hold program open until user hits Return or exits the console
        }

    }
}
