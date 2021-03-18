using System;

namespace Data_Types
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int x = 5, y = 7;
            Person john = new Person();
            Person mary = new Person();

            mary.FirstName = "Mary";
            john.FirstName = "John";
            john.LastName = "Doe";

            mary.LastName = john.LastName;
            Console.Write($"Person name and surname  :  { mary.FirstName}  : {mary.LastName} and   {john.FirstName} : {john.LastName}\n");
            
        }
        
    }
   
}

