using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidOverloadStatic
{
    class Method3
    {
        public void Display(out int a)
        {
            int b = 10;  //Creates a variable b and assigns a value of 10
            a = +b;  //Equivalent to: "a = b" - assigns the value from right side operands to left side operand
            a += a;  //Equivalent to: "a = a + b" - adds the right operand to the left operand and assigns the result to the left operand
            Console.WriteLine("Value inside the function: " + a);  //Prints message and operation reesult to console
        }
    }
}
