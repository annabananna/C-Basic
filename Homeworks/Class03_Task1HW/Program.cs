using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System;

namespace Task1HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Make a console application called SumOfEven. Inside it create an array of 6 integers.Find and print the sum of
            //            the even numbers from the array.

            int[] evenOrOddNumbers = new int[0];

            while(true)
            {
                if(evenOrOddNumbers.Length < 6)
                {
                    Console.WriteLine("Please enter integer number");
                    if(!int.TryParse(Console.ReadLine(), out int num))
                    {
                        Console.WriteLine("Wrong input, please enter integer");
                    }
                    else
                    {
                        Array.Resize(ref evenOrOddNumbers, evenOrOddNumbers.Length + 1);
                        evenOrOddNumbers[evenOrOddNumbers.Length - 1] = num;
                    }

                } 
                else
                {
                    break;
                }
            }

            Console.WriteLine(evenOrOddNumbers[0]);
            Console.WriteLine(evenOrOddNumbers[1]);
            Console.WriteLine(evenOrOddNumbers[2]);
            Console.WriteLine(evenOrOddNumbers[3]);
            Console.WriteLine(evenOrOddNumbers[4]);
            Console.WriteLine(evenOrOddNumbers[5]);

            int sum = 0;
            for (int i = 0; i < evenOrOddNumbers.Length; i++)
            {
                if (evenOrOddNumbers[i] % 2 == 0)
                {
                    sum += evenOrOddNumbers[i];
                }
            }
            Console.WriteLine($"Sum is: {sum}");
        }
    }
}