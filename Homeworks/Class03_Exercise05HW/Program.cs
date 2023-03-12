using System;

namespace Exercise05HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Declare a new array of integers with 5 elements
            //Initialize the array elements with values from input
            //Sum all the values and print the result in the console

            int[] arrayOne = new int[0];

            while(true)
            {
                if (arrayOne.Length < 5)
                {
                    Console.WriteLine("Please enter a number");
                    if (!int.TryParse(Console.ReadLine(), out int num))
                    {
                        Console.WriteLine("wrong input");
                    }
                    else
                    {
                        Array.Resize(ref arrayOne, arrayOne.Length + 1);
                        arrayOne[arrayOne.Length - 1] = num;
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(arrayOne[0]);
            Console.WriteLine(arrayOne[1]);
            Console.WriteLine(arrayOne[2]);
            Console.WriteLine(arrayOne[3]);
            Console.WriteLine(arrayOne[4]);

            int sum = 0;
            foreach (int item in arrayOne)
            {
                sum += item;
            }

            Console.WriteLine($"Sum is: {sum}");

        }
    }
}