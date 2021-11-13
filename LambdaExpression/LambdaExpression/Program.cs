using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> empList = new List<Employee>(); //List is an object which holds objects in a specific order

            empList.Add(new Employee() //Adds Employee object to list
            {
                Id = 1, FirstName = "Fred", LastName = "Wilson"  //Individual Employee object attributes
            });
            empList.Add(new Employee() //Adds Employee object to list
            {
                Id = 2, FirstName = "Louis", LastName = "Anderson" //Individual Employee object attributes
            });
            empList.Add(new Employee() //Adds Employee object to list
            {
                Id = 3, FirstName = "Joe", LastName = "McClean" //Individual Employee object attributes
            });
            empList.Add(new Employee() //Adds Employee object to list
            {
                Id = 4, FirstName = "Susan", LastName = "Bahnsen" //Individual Employee object attributes
            });
            empList.Add(new Employee() //Adds Employee object to list
            {
                Id = 5, FirstName = "Barbara", LastName = "Strickland" //Individual Employee object attributes
            });
            empList.Add(new Employee() //Adds Employee object to list
            {
                Id = 6, FirstName = "Frederick", LastName = "Peters" //Individual Employee object attributes
            });
            empList.Add(new Employee() //Adds Employee object to list
            {
                Id = 7, FirstName = "Joe", LastName = "McCarthur" //Individual Employee object attributes
            });
            empList.Add(new Employee() //Adds Employee object to list
            {
                Id = 8, FirstName = "Frances", LastName = "Johanson" //Individual Employee object attributes
            });
            empList.Add(new Employee() //Adds Employee object to list
            {
                Id = 9, FirstName = "Louie", LastName = "Salvatore" //Individual Employee object attributes
            });
            empList.Add(new Employee() //Adds Employee object to list
            {
                Id = 10, FirstName = "Kelly", LastName = "Clarkson" //Individual Employee object attributes
            });

            //Loop that iterates all objects in list assigning the keyword "data" to objects
            foreach (var data in empList)
            {
                if (data.FirstName == "Joe") 
                //Prints Employee Id, FirstName, LastName as a vertical list to console for objects with the first name "Joe"
                Console.WriteLine("Id: {0}, Name: {1} {2}", data.Id, data.FirstName, data.LastName);
            }
            Console.ReadLine(); //Holds open console for next section of code to run

            
            Console.WriteLine("Retrieving employees with an Id greater than 5\n");
            //Lambda expression inserted into foreach loop to iterate list Employee
            //to identify all Id's > 5 assigning the keyword "data" to objects
            foreach (Employee data in empList.FindAll(e => (e.Id > 5)).ToList())
            {
                //Prints Employee Id, FirstName, LastName as a vertical list to console for objects with an Id > 5
                Console.WriteLine("Id: {0}, Name: {1} {2}", data.Id, data.FirstName, data.LastName);
            }
            Console.ReadLine(); //Holds open console until user executes Return or exits the console

        }
        
    }
}
