using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodWithOptionalEntry
{
    class Option  //Class named Method that will be called by Program.cs 
    {
        public int Operation(int x, int y=1)  //Public method that takes in two user entry parameters 
        {
            int result = x * y;  //Operation multiplying both parameters
            return result;  //Terminates execution of the method and returns control to the calling method
        }
    }
}

