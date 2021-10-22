using System;

namespace ShippingQuoteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxWeight = 50;  //Total weight condition for shipping

            //Shipping quote page greeting
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            //First package inquiry - weight
            Console.WriteLine("Please provide the weight of your package:");  //user entry
            int packageWeight = Convert.ToInt32(Console.ReadLine());  //casting string to int

            if (packageWeight > maxWeight)  //Total weight condition for shipping
            {
                Console.Write("Package too heavy to be shipped via Package Express. Have a good day.");  //Prints to console is weight exceeds maxWeight
                Console.ReadLine();  //Pauses and holds open console for next section of program to run
                Environment.Exit(0);  //Exits program if condition not met
            }
            Console.ReadLine();  //Pauses and holds open console for next section of program to run


            int totalDimensions = 50;  //Total dimensions condition for shipping
            int packageDivisor = 100;  //Variable used as divisor to final total width, height, length, weight calculation

            //First package inquiry - width
            Console.Write("Please provide package width: \n");
            int packageWidth = Convert.ToInt32(Console.ReadLine());  //casting string to int

            //First package inquiry - height
            Console.Write("Please provide package height: \n");
            int packageHeight = Convert.ToInt32(Console.ReadLine());  //casting string to int

            //First package inquiry - length
            Console.Write("Please provide package length:\n");
            int packageLength = Convert.ToInt32(Console.ReadLine());  //casting string to int

            if (packageWidth + packageHeight + packageLength > totalDimensions)  //Total dimensions condition for shipping
            {
                Console.Write("Package too big to be shipped via Package Express.");  //Prints to console is weight exceeds totalDimensions           
                Console.ReadLine();  //Pauses and holds open console for next section of program to run
                Environment.Exit(0);  //Exits program if condition not met
            }

            else  //Condition if does not exceed totalDimensions 
            {
                //Calculates final shipping cost and prints to console
                Console.Write("Your estimated total for shipping this package is: " + packageWidth * packageHeight * packageLength * packageWeight / packageDivisor + "\n");
                Console.Write("Thank you!");  //Prints to console 
            }
            Console.ReadLine();  //Pauses and holds open console until user closes program

        }
    }
}
