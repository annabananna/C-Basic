using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Class04HW_Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 3
            //Create a function that takes a number as input.This method should return the sum of the digits in the number.
            Console.WriteLine("Please enter a number");

            string myNumber = Console.ReadLine();
            string numbers = myNumber.ToString();
            Console.WriteLine(numbers);
            char[] numbersArray = numbers.ToCharArray();
            
            int sum = 0;
            for(int i = 0; i < numbersArray.Length; i++)
            {
                sum += int.Parse(numbersArray[i].ToString());
            }
            Console.WriteLine($"The sum of the numbers is: {sum}");

        }
    }
}