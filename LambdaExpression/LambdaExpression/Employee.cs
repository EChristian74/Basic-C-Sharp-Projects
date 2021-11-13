namespace LambdaExpression
{
    internal class Employee
    {
        public Employee() //Class Employee used to 
        {
        }

        //Get and set allows us to creating properties for a class ini C# without having 
        //to define private variables for them
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}