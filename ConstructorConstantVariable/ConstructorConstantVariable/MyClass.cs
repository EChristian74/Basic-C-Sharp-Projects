using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorConstantVariable
{
    public class NewEmployee //Class NewEmployee
    {
        public string firstName; //Declares property firstName
        public string lastName; //Declares property lastName
        
        //This is a two parameter constructor method
        //However, a default value is preset for lastName
        //First constructor
        public NewEmployee(string fName) : this(fName, "Boland")
        {
            
        }
        
        //This is a two parameter constructor method
        //Second constructor
        public NewEmployee(string fName, string lName)
        {
            lastName = lName; //Instantiates lastName property
            firstName = fName; //Instantiates firstName property
        }   
    }
}



