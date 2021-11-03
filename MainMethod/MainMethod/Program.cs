using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
       

        public static void Main(string[] args)
        {

            var operatorObject = new Operations();  //Creates variable that is used for all three methods

            Console.WriteLine("Please enter a whole number: ");  //Instructs user to enter a number
            int dataEntry1 = Convert.ToInt32(Console.ReadLine());  //Program reads user data entry and sets entry data type
            var result1 = operatorObject.Add(dataEntry1);  //Calls method Add 
            Console.WriteLine("The result of the method is " + result1);  //Writes result statement to console

            Console.WriteLine();  //Blank line

            Console.WriteLine("Please enter a decimal: ");  //Instructs user to enter a decimal
            decimal dataEntry2 = Convert.ToDecimal(Console.ReadLine());  //Program reads user data entry and sets entry data type
            int result2 = operatorObject.Dec(dataEntry2);  //Calls method Dec
            Console.WriteLine("The result of the method is " + result2);  //Writes result statement to console

            Console.WriteLine();  //Blank line

            Console.WriteLine("Please enter a numeric string: ");  //Instructs user to enter a string
            string dataEntry3 = Console.ReadLine();  //Program reads user data entry and sets entry data entry (string) - Console.ReadLine() default data type is string
            int result3 = operatorObject.Integer(dataEntry3);  //Calls method Integer
            Console.WriteLine("The result of the method is " + result3);  //Writes result statement to console

            Console.ReadLine();  //Pauses and holds open console until user hits Return or Exits console


            

            

        }
    }
}
