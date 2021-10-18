using System;


namespace AnonIncomeCompProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Income Comparison Program Header
            Console.WriteLine("Anonymous Income Comparison Program"); //prints to console
            Console.ReadLine();  //pauses to display of header to console

            //Label to identify Person 1
            Console.WriteLine("Person 1:");  //prints to console
            Console.ReadLine();  //pauses and holds program open to run next section of program

            //Question - hourly rate for Person 1
            Console.WriteLine("Hourly Rate?");  //prints to console
            string hourlyRate1 = Console.ReadLine();  //data entry
            int rate1 = Convert.ToInt16(hourlyRate1);  //casting string to int
            Console.ReadLine();  //pauses and holds program open to run next section of program

            //Question - hours for Person 1
            Console.WriteLine("Hours worked per week?");  //prints to console
            string hoursPer1 = Console.ReadLine();  //data entry
            int hours1 = Convert.ToInt16(hoursPer1);  //casting string to int
            Console.ReadLine();  //pauses and holds program open to run next section of program

            //Label to identify Person 2
            Console.WriteLine("Person 2:");  //prints to console
            Console.ReadLine();  //pauses and holds program open to run next section of program

            //Question - hourly rate of Person 2
            Console.WriteLine("Hourly Rate?");  //prints to console
            string hourlyRate2 = Console.ReadLine();  //data entry
            int rate2 = Convert.ToInt16(hourlyRate2);  //casting string to int
            Console.ReadLine();  //pauses and holds program open to run next section of program

            //Question - hours for Person 2
            Console.WriteLine("Hours worked per week?");  //prints to console
            string hoursPer2 = Console.ReadLine();  //data entry
            int hours2 = Convert.ToInt16(hoursPer2);  //casting string to int
            Console.ReadLine();  //pauses and holds program open to run next section of program

            //Annual salary of Person 1 based on 52 weeks per year
            Console.WriteLine("Annual salary of Person 1:");  //prints to console
            int product1 = (int)Convert.ToInt16(hourlyRate1) * (int)Convert.ToInt16(hoursPer1) * (int)Convert.ToInt16(52);  //calculates annual salary
            Console.WriteLine(product1);  //prints to console
            Console.ReadLine();  //pauses and holds program open for next section of program

            //Annual salary of Person 2 based on 52 weeks per year
            Console.WriteLine("Annual salary of Person 2:");  //prints to console
            int product2 = (int)Convert.ToInt16(hourlyRate2) * (int)Convert.ToInt16(hoursPer2) * (int)Convert.ToInt16(52);  //calculates annual salary
            Console.WriteLine(product2);  //prints to console
            Console.ReadLine();  //pauses and holds program open for next section of program

            //Comparison of Person 1 salary vs. Person 2 salary
            Console.WriteLine("Does Person 1 make more money than Person 2?");  //prints to console
            bool comparison = Convert.ToUInt32(product1) > Convert.ToInt32(product2);  //compares annual salaries
            Console.WriteLine(comparison);  //prints True or False to console
            Console.ReadLine();  //pauses and holds program open to view all program results


        }
    }
}
