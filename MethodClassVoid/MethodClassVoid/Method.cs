using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassVoid
{
    class Method  //Class named Method that will be called by Program.cs
    {
        public void Operation(int a, int b)  //Void method that takes in two user entry integer parameters
        {
            a = a + 20;  //Performs math operation of user entry (a) plus 20 - NOTE: DOES NOT PRINT TO CONSOLE
            Console.WriteLine(b);  //Prints user entry (b) to console
        }
    }
}
