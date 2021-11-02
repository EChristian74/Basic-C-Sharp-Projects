using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        //Instantiation of and addition of string elements to a new list
        List<int> intList = new List<int>() { 12, 25, 36, 50, 72, 100 };

        Console.WriteLine("Division Program");  //Displays name of program to console      
        Console.WriteLine("Pick a number that will be used to divide each number in the list:");  //Instruction to user
        
        //Try statement that houses all exception handling code
        try
        {
            int responseInt = Convert.ToInt32(Console.ReadLine());  //Casts user data entry
            foreach (int integer in intList)  //Instructs program to iterate all index positions in list  
            {
                Console.WriteLine(integer / responseInt);  //Instruction to program to perform this math calculation
            }
        }
        //Catch 1: If user enters number other tha whole number 
        catch (FormatException ex)  //Built-in exception specific to format
        {
            Console.WriteLine("Please type a whole number.");  //Prints message to use whole number to console
            return;
        }
        //Catch 2: If user enters "0"
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero.");
        }
        //Catch 3: General catch that allows for handling of other built-in exception errors
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);  //Catch clause exception handler that displays format exception message (i.e. string)
        }
        //Finally: Executes when the try/catch block leaves the execution - releases system resources
        finally
        {
            Console.ReadLine();  //Pauses and hold open program program for next section of code to run
        }
        Console.WriteLine("The number(s) you have enters are valid.");  //Display message to console confirming numbers entered are valid
        Console.ReadLine();  //Holds program open until user hits Return or exits the console
    } 
}




