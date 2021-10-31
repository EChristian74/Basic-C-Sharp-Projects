using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    //Operator = class (model) designated as "public" so that it is accessible to Program.cs
    public class Operator  //instantiates the object "Operator"
    {
        public double GetAdd(int data)  //method 1: adds 36 to user integer data entry
        {
            data = data + 36;
            return GetSubtract(data);  //returns math operation result
        }

        private double GetSubtract(double data)  //method 2: subtracts from the return of GetAdd
        {
            data = data - 8;
            return GetMultiply(data);  //returns math operation result
        }

        private double GetMultiply(double data)  //method 3: multiplies by return of GetSubtract
        {
            data = data - 3;
            return GetDivide(data);  //returns math operation result
        }

        private double GetDivide(double data)  //method 4: divides by return of GetMultiply
        {
            return data / 2;  //returns math operation result
        }
    }
}
