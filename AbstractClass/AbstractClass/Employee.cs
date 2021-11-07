using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    //Sub-class that inherits super-class Person 
    public class Employee : Person
    {
        //override keyword in this method allows SayName() method to be instantiated
        //in cooperation with the virtual keyword in Person.cs
        public override void SayName()  
        {
            base.SayName();  //calls SayName() method
        }
    }
}
