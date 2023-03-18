using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace Class05_Task1HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a class Human
            //Add properties: FirstName, LastName, Age
            //Create a method called GetPersonDetails that returns the full name of the human as well as their age
            //Create an object human by asking the user to fill the required information(take first name, last name and age from user input)
            //Call the GetPersonDetails method and print the result in the console after the object is created

            Console.WriteLine("Please enter your name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name");
            string lastName = Console.ReadLine();

            int age = 0;

            Console.WriteLine("Please enter your Age");

            while (true)
            {
                
                if(!int.TryParse(Console.ReadLine(), out  age))
                {
                    Console.WriteLine("Please enter a valid number");
                }else
                {
                    break;
                }
            }


            Human h1 = new Human(firstName, lastName, age);

            h1.FirstName = firstName;
            h1.LastName = lastName;
            h1.Age = age;

            Console.WriteLine(h1.GetPersonDetails());

        }
    }
}