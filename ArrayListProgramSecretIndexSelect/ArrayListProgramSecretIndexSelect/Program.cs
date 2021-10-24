using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        //Program header
        Console.WriteLine("Secret Password and Passcode Generator"); //prints to console
        

        //Initiates/instantiates new string array
        string[] password = { "BileGful", "exREgIst", "nEOtaiNy", "strUcIst", "reINvoKy" };

        //Question 1: String index for array
        Console.WriteLine("Enter a number 0-4 to receive a secret password:"); //prints to console
        int resp1 = int.Parse(Console.ReadLine());

        if (resp1 > 4)  //condition to receive password
        {
            Console.WriteLine("Selection is invalid.");  //prints to console when condition not met
        }
        else
        {
            Console.WriteLine(password[resp1]);  //prints password to console when condition met
        }
        Console.ReadLine();  //pauses and holds open console for next section of program



        //Initiates/instantiates new integer array
        int[] passcode = { 6834, 2987, 3928, 3476, 8710 };

        //Question 2: Integer Index for array
        Console.WriteLine("Enter a number 0-4 to receive a secret passcode:"); //prints to console
        int resp2 = int.Parse(Console.ReadLine());  // data entry

        if (resp2 > 4)  //condition to receive passcode
        {
            Console.WriteLine("Selection is invalid.");  //prints to console when condition not met
        }
        else
        {
            Console.WriteLine(passcode[resp2]);  //prints passcode to console when condition met
        }
        Console.ReadLine();  //pauses and holds open console for next section of program


        //Initiates/instantiates new list of strings
        List<string> phrase = new List<string>();
        phrase.Add("Cowa Bunga Dude");
        phrase.Add("Fedora The Explorer");
        phrase.Add("Kentucky Fried Chicks");
        phrase.Add("Just Nuke It");
        phrase.Add("Faster Than FedEx");

        //Question 3: Integer index for list
        Console.WriteLine("Enter a number 0-4 to receive a secret passphrase:"); //prints to console
        int resp3 = int.Parse(Console.ReadLine());  // data entry

        if (resp3 > 4)  //condition to receive phrase
        {
            Console.WriteLine("Selection is invalid.");  //prints to console when condition not met
        }
        else
        {
            Console.WriteLine(phrase[resp3]);  //prints phrase to console when condition met
        }
        Console.ReadLine();  //pauses and holds open console until user hits Return or exits console

    }
}

        


 
