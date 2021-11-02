using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Operators
    {
        public double GetAdd(int data)  //method 1: adds 5 to user integer data entry
        {
            return data + 5;  //method operation (addition)
        }
        public double GetSubtract(int data)  //method 2: subtracts 5 from user integer data entry
        {
            return data - 5;  //method operation (subtraction)
        }
        public double GetMultiply(int data)  //method 3: multiplies user integer data entry by 5
        {
            return data * 5;  //method operation (multiplication)
        }
        public double GetDivide(int data)  //method 4: divides user integer data entry by 5
        {
            return data / 5;  //method operation (division)
        }
    }
}


