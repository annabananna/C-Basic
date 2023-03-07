using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.

            Console.WriteLine("Enter the First number");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Wrong input");
                return;
            }

            Console.WriteLine("Enter the Second number");
            if(!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Wrong input");
                return;
            }

            Console.WriteLine("Enter the Third number");
            if(!double.TryParse(Console.ReadLine(), out double num3))
            {
                Console.WriteLine("Wrong input");
                return;
            }

            Console.WriteLine("Enter the Four number");
            if(!double.TryParse(Console.ReadLine(),out double num4))
            {
                Console.WriteLine("Wrong input");
                return;
            }
            double result = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine($"Average number is {result}");
        }
    }
}