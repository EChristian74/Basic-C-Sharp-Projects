using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodObjectInheritance
{
    public class Person  //Super-class
    {
        public string FirstName { get; set; }  //Creates property FirstName
        public string LastName { get; set; }  //Creates property LastName

        public void SayName()  //Method SayName that is called by main program via the Employee sub-class
        {
            //Writes this text instantiating the FirstName and LastName via the main program
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
