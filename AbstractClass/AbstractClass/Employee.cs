using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    //Sub-class that inherits super-class Person 
    public class Employee : Person, IQuittable  //multiple inheritances
    {
        //override keyword in this method allows SayName() method to be instantiated
        //in cooperation with the virtual keyword in Person.cs
        public override void SayName()  
        {
            base.SayName();  //calls SayName() method
        }
        //inherited method from IQuittable interface
        //note: satisfies requirement even with no implementation
        public void Quit()
        {
            //temporary exception until implementation code is added
            Console.WriteLine("Informed HR that today will be their last day.");
        }
    }
}
