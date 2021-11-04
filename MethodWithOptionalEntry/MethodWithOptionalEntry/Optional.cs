using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodWithOptionalEntry
{
    class Method  //Class named Method that will be called by Program.cs 
    {
        public int Optional(int x, int y = 0)  //Public method that takes in two user entry parameters 
        {
            return x + y;  //Terminates the execution of the method in which it appears and returns the control back to the calling method
        }
    }
}
