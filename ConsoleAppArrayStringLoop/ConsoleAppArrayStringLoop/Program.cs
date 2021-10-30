using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //ASSIGNMENT ONE/PART ONE: One-dimensional array of strings
        string[] cities = { "Amarillo, ", "Lubbock, ", "Dallas, ", "San Antonio, ", "Houston, " };

        //Opening statement providing user instruction that prints to console
        Console.WriteLine("Please give the state abbreviation \nfor the cities of Amarillo, Lubbock, \nDallas, San Antonio, and Houston in all caps?");
        string response1 = (Console.ReadLine());  //user data entry

        for (int i = 0; i < cities.Length; i++)  //loop that iterates the array up to the number of index positions
        {
            cities[i] = cities[i] + response1;  //statement that concatenates original array strings and user input   
            Console.WriteLine("Result (after joining) = " + cities[i]);  //Updated array of strings that prints to console
        }
        Console.ReadLine();  //holds open program for next section of code to run 


        Console.WriteLine(" ");  //Simply inserts an extra blank line


        //ASSIGNMENT TWO: Add infinite loop, then fix the loop so that it will execute properly
        string[] websites = { "Google", "Facebook", "Twitter", "Instagram", "YouTube" };

        //Opening statement providing user instruction that prints to console
        Console.WriteLine("Press the Return button key on your \nkeyboard to see a list of internet browsers with \nletter \"o\" in the name.");
        Console.ReadLine();  //Pauses program to display instruction to console

        int j = 0;  //Creates variable assigned to index positions in array

        while (j < websites.Length)  //Loop that iterates array of strings (browser names)
        {
            //Only output those sites with an 'o' in the name
            if (websites[j].Contains("o"))  //Condition if the string contains the letter "o"
            {
                Console.WriteLine(websites[j]);  //prints browser names that meet condition to console
            }
            j++;  //Denotes that the loop will increment
        }
        Console.ReadLine();  //Holds open program for next section of code to run 



        //ASSIGNMENT THREE(Part One): Comparison loop with less than operator

        //While loop quiz asking of the top five favorite lucky number that people choose, which is #1
        Console.Write("Choose a number less than 100 from which this loop will iterate downward. \n");
        string response2 = Console.ReadLine();  //user data entry
        int resp2 = Convert.ToInt32(response2);  //casting, string to integer  

        Console.Write("");  //Blank line

        while (resp2 < 100)  //loop that iterates from a number selected by user below 100
        {
            //Conditions that tells loop to count downward, not upward
            Console.WriteLine(resp2);
            resp2--;

            //Conditions to stop loop once loop counts down to 1
            if (resp2 < 1)
                break;
        }
        Console.ReadLine();  //Holds open program for next section of code to run 



        //ASSIGNMENT THREE (Part One): Comparison loop with less than or equal to operator
        Console.WriteLine("Create multiplication tables based on a base number of your choosing time 1 to 20.");
        Console.ReadLine();

        Console.Write("Choose a base number:");  //Instruction to user
        int TableOf = int.Parse(Console.ReadLine());  //user data entry

        int TotalLength = 1;  //Creates variable assigned to index positions in array

        while (TotalLength <= 20)  //Condition if that stops the loop once the base number is multiple by numbers 1-20
        {
            int TableValue = TotalLength * TableOf;  //Establishes the table structure
            Console.WriteLine("{0} x {1} = {2}", TableOf, TotalLength, TableValue);  //Creates the condition
            if (TotalLength == 10)
            {
                Console.WriteLine("\n");  //Simply write an extra blank line grouping tables in groups of 10
            }
            TotalLength++;  //Denotes that the loop will increment          
        }
        Console.ReadLine();  //Holds open program for next section of code to run 



        //ASSIGNMENT FOUR: List of strings, user enters search text, looper interates for match,
        //includes exception if search criteria not in list, then loop stops once a match is found

        //Opening statement that informs user regarding the purpose of this program
        Console.WriteLine("Can you guess any of the top five luxury supercars in the world?");

        //Creation of and addition of string elements to a new list
        List<string> cars = new List<string>() { "Porsche", "Ferrari", "Maserati", "Aston Martin", "Alfa Romeo" };

        Console.WriteLine(" ");  //Blank line

        Console.WriteLine("Enter your guess: \n");  //Instruction to user to enter a guess
        string response3 = (Console.ReadLine());  //User data entry

        foreach (string car in cars)  //Condition to iterate all strings in list
        {
            if (response3 == car)  //Condition to match user input against strings in list 
            {
                //Condition to write the index # and the actual string if a match is found
                Console.WriteLine("That brand is in the top 5!");  //Prints phrase to console when met

                int index = cars.IndexOf(response3);  //
                Console.WriteLine($"{index}");  //When a match occurs, prints index # and correlating string to console
                break;  //Tells program to break if condition met
            }
            else
            {
                //Message to inform if the user guess is incorrect
                Console.WriteLine("That brand is not in the top 5.");  //Prints phrase to console when not met for each list item
            }
        }
        Console.ReadLine();  //Holds open program for next section of code to run 



        //ASSIGNMENT FIVE: List of strings with two identical strings in list, asks user to search list,
        //loop interates through list, displays indices of matching items, loop that checks user input

        //Opening statements that informs user regarding the purpose of this program
        Console.WriteLine("In my home I have many TV\'s made by Sony, Samsung, Toshiba, Life is Good, and Roku, two of which are the same brand.");
        Console.WriteLine("Of all my TV\'s, can you guess of which brand that I have more than one TV?");

        //Creation of and addition of string elements to a new list
        List<string> brands = new List<string>() { "Sony", "Samsung", "Toshiba", "Life is Good", "Roku", "Samsung" };

        Console.WriteLine("Enter your guess: \n");  //Instruction to user to enter a guess
        string response4 = (Console.ReadLine());  //User data entry

        for (int i = 0; i < brands.Count; i++)  //Instruction to iterate all strings in list
        {
            if (brands[i] == response4)  //Condition if user data entry matches string in list
            {
                Console.WriteLine("Match found at index " + i);  //Writes message to console confirming a match
            }
        }
        if (!brands.Contains(response4))  //Condition if user data entry does not match string in list
        {
            Console.WriteLine("Match not in the list.");  //Write message to console confirming not a match
        }
        Console.ReadLine();  //Pauses and holds open console until user hits Return or exits console



        //ASSIGNMENT SIX: List of strings with two identical strings in list, asks user to search list,
        //loop interates through list, displays indices of matching items, loop that checks user input

        //Opening statements that informs user regarding the purpose of this program
        Console.WriteLine("The students in my small classroom are named John, Sue, Bobby, Patricia, Frederick, and Pepe.");
        Console.WriteLine("Of all student names in my classroom, can you guess which name occurs more than once?");

        //Creation of and addition of string elements to a new list
        List<string> students = new List<string>() { "John", "Sue", "Bobby", "Patricia", "Frederick", "Pepe", "Sue" };

        Console.WriteLine(" ");  //Blank line

        Console.WriteLine("Enter your guess: \n");  //Instruction to user to enter a guess
        string response5 = (Console.ReadLine());  //User data entry
        List<string> students2 = new List<string>();  //Creates empty list 

        foreach (string student in students)  //Condition for list iteration
        {
            if (!students2.Contains(student))   //Condition if data entry is not a match
            {
                students2.Add(student);  //Writes data to new list
                Console.WriteLine(student + " was not in the list.");  //Prints message to console when condition not met
            }
            else if (students2.Contains(student))  //Condition if data entry is a match
            {
                //Message to inform if the user guess is incorrect
                Console.WriteLine(student + " was on the list.");  //Prints phrase to console when condition is met
            }
        }
        Console.ReadLine();  //Pauses and holds open console until user hits return or exits console
    }
}




