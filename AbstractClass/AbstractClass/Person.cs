using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Person  //Super-class
    {
        public string firstName { get; set; }  //Creates property FirstName
        public string lastName { get; set; }  //Creates property LastName

        //virtual method allows method to be instantiated despite abstract class nesting
        public virtual void SayName()  //
        {
            //Writes this text instantiating the firstName and lastName via the main program
            Console.WriteLine(firstName + " " + lastName);

        }
    }
}
