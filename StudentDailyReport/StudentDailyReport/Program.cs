using System;


namespace StudentDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {

            //Student Daily Report Header
            Console.WriteLine("The Tech Academy \nStudent Daily Report"); //prints to console
            Console.ReadLine();  //pauses to display of header to console

            //Question for name, then student keys in name
            Console.WriteLine("What is your name?");  //prints to console
            string yourName = Console.ReadLine();  //student data entry
            Console.ReadLine();  //pauses and waits for an input

            //Question to verify current course, then student keys in course name
            Console.WriteLine("What course are you on?");  //prints to console
            string yourCourse = Console.ReadLine();  //student data entry
            Console.ReadLine();  //pauses and waits for an input 

            //Question to verify current page number, then student keys in page number
            Console.WriteLine("What page number?");  //prints to console
            string coursePage = Console.ReadLine();  //student data entry
            int cPage = Convert.ToInt32(coursePage);  //casting, string to integer
            Console.ReadLine();  //pauses and waits for an input

            //Question to verify if student needs help, then student keys in "True" or "False"
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");  //prints to console
            string needHelp = Console.ReadLine();  //student data entry
            bool helpStatus = Convert.ToBoolean(needHelp);  //casting, boolean to string
            Console.ReadLine();  //pauses and waits for an input

            Console.WriteLine(" ");

            //Question to verify any positive experiences, then student keys in any positive feedback
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");  //prints to console
            string yourFeedback1 = Console.ReadLine();  //student data entry
            Console.ReadLine();  //pauses and waits for an input

            //Question to verify any other feedback, then student keys in any other feedback
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");  //prints to console
            string yourFeedback2 = Console.ReadLine();  //student data entry
            Console.ReadLine();  // pauses and waits for an input

            //Question to verify number of study hours, then student keys in the number of study hours
            Console.WriteLine("How many hours did you study today?");  //prints to console
            string studyHours = Console.ReadLine();  //student data entry
            int sHours = Convert.ToInt32(studyHours);  //casting, string to integer
            Console.ReadLine();  // pauses and waits for an input

            //Student Daily Report Closing
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");  //prints to console
            Console.ReadLine();  //pauses to display closing to console
        }
    }
}
