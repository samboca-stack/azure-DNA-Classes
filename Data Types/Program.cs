using System;

namespace Data_Types
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int x = 5, y = 7;
            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Doe";
            john.Gender = "Male";
            Person mary = new Person();
            mary.Gender = "Female";
            mary.LastName = john.LastName;
            mary.FirstName = "Mary";
           
           
            Console.Write($"Person name and surname  :  { mary.FirstName}  : {mary.LastName} and   {john.FirstName} : {john.LastName}\n");

            var person = john;

            Console.WriteLine("Please write your Gender/n");
            person.Gender = Console.ReadLine();

            while (person.Gender != null)
            {

                if (person.Gender == "male")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"\nPerson anme : {person.FirstName} {person.LastName} \n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"Person anme : {person.FirstName} {person.LastName} \n");
                }

                switch (person.Gender)
                {
                    case "male":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"\nPerson anme : {person.FirstName} {person.LastName} \n");
                        break;
                    
                    case "female":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Person name : {person.FirstName} {person.LastName} \n");
                        break;

                }
                Console.WriteLine("Please write your Gender/n");
                person.Gender = Console.ReadLine();
                break;
            }
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\nEnter your Age : ");
            person.Age = Convert.ToInt32(Console.ReadLine());

            while (person.Age != 0)
            {


                if (person.Age < 20)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Person age : {person.Age}  \n");
                }
                else if (person.Age >= 20 & person.Age < 30)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Person age : {person.Age}  \n");
                }

                else if (person.Age >= 30 & person.Age < 50)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Person age : {person.Age}  \n");
                }
                else if (person.Age >= 50 & person.Age < 60)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Person age : {person.Age}  \n");
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nEnter your Age : ");
                person.Age = Convert.ToInt32(Console.ReadLine());
                break;
            }

            //Student enter name and marks
            Console.ForegroundColor = ConsoleColor.White;
            student lucky = new student();

            var student = lucky;
    
            Console.WriteLine("\n Please enter your name below \n");
            student.name = Console.ReadLine();
            int count = 0;
            while (lucky.name != null &  count <5 ) 
            {
                Console.WriteLine($"\n {student.name} please enter your test mark below\n");
                student.marks = Convert.ToInt16(Console.ReadLine());

                if (student.marks < 34 )
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{student.name} : you have failed with {student.marks} %\n");

                }

                else if (student.marks >= 34 & student.marks <= 50)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{student.name} : you have passed with {student.marks} %\n");
                }

                else if (student.marks > 50 & student.marks <= 74)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{student.name} : well done you have passed with {student.marks} %\n");
                }

                else if ( student.marks >=75 & student.marks <=100)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{student.name} : congrats excellent passed with {student.marks} %\n");
                }


                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n Please enter your name below \n");
                student.name = Console.ReadLine();
                count++;

            }
        }
        
    }
   
}

