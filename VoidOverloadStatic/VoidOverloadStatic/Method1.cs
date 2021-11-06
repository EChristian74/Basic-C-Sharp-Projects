using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidOverloadStatic
{
    class Method1  //Class named Divide that will be called by Program.cs
    {
        public int y { get; private set; }

        public void Operation(int x)  //Void method that takes in user entry parameters
        {
            y = 2;  //Creates variable "y" that will be used to divide user input in math operation
            x = x / y;  //Creates a callable variable that performs an math operation that divides user input by y(2)
            Console.WriteLine(x);  //Prints operation result to console
        }  

        public void Operation(string s)  //Overload method that takes in user entry parameters
        {
            Console.WriteLine("My favorite color is " + s + ".");  //Prints message concatenated with user input
        }



    }
}
