using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Swap numbers");
            //Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables
            //so that the first variable has the second value and the second variable the first value. Please find example below:
            Console.WriteLine("Please enter the first number");
            string firstN = Console.ReadLine();
            bool firstParse = double.TryParse(firstN, out double num1);
            if (!firstParse)
            {
                Console.WriteLine("Please enter number");
                return;
            }

            Console.WriteLine("Please enter the second number");
            if(!double.TryParse(Console.ReadLine(), out double  num2))
            {
                Console.WriteLine("Wrong input");
            }
            double temp = num1;
            num1 = num2;
            num2 = temp;




            Console.WriteLine($"First number {num1}");
            Console.WriteLine($"Second number {num2}");
        }
    }
}