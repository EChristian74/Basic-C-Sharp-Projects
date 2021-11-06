using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidOverloadStatic
{
    public static class Calculator  //Class named calculator that will be called by Program.cs
    {
        private static int _resultStorage = 0;  //Creates _resultStorage parameter

        public static int Sum(int num1, int num2)  //Parameters for sum operation
        {
            return num1 + num2;  //Returns value of num1 + num2
        }

        public static void Store(int result)  //Parameter for sum result
        {
            _resultStorage = result;  //Stores the result value in memory
        }
    }
}
