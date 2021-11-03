using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    //Class (method) Operations
    public class Operations
    {
        //Method 1: Add
        public int Add(int data)  //public int = output | Add(int data) = data entry input
        {
            //No need to convert data type of input due to integer to integer exercise
            return data + 5;  //method operation (addition)
        }

        //Method 2: Dec
        public int Dec(decimal data)  //public int = output | Dec(decimal data data) = data entry input
        {
            int x = Convert.ToInt32(data);  //converts data type of input from decimal to integer
            return x * 5;  //method operation (multiplication)
        }

        //Method 3: Integer
        public int Integer(string data)  //public int = output | Integer(int data) = data entry input
        {
            int y = Convert.ToInt32(data); //converts data type of input from string to integer
            return y / 5;  //method operation (division)
        }
















    }
}
