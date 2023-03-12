using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System;

namespace Task02HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Make a new console application called StudentGroup
            //Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names(strings).
            //Get a number from the console between 1 and 2 and print the students from that group in the console.

            string[] studentsG1 = new string[0];
            string[] studentsG2 = new string[0];

            while(true)
            {
                if(studentsG1.Length < 5)
                {
                    Console.WriteLine("Please enter students in G1");
                    string input = Console.ReadLine();
                    Array.Resize(ref studentsG1, studentsG1.Length + 1);
                    studentsG1[studentsG1.Length - 1] = input;
                }
                else
                {
                    break;
                }
            }

            while (true)
            {
                if (studentsG2.Length < 5)
                {
                    Console.WriteLine("Please enter students in G2");
                    string input2 = Console.ReadLine();
                    Array.Resize(ref studentsG2, studentsG2.Length + 1);
                    studentsG2[studentsG2.Length - 1] = input2;
                }
                else
                {
                    break;
                }
            }

            Console.Write("Please enter 1 or 2");
            string output = Console.ReadLine();
            if(output == "1")
            {
                Console.WriteLine("The Students in G1 are: ");
                for (int i = 0; i < studentsG1.Length; i++)
                {
                    Console.WriteLine($"{studentsG1[i]}");
                }
            }
            else if (output == "2")
            {
                Console.WriteLine("The Students in G2 are: ");
                for (int i = 0; i < studentsG2.Length; i++)
                {
                    Console.WriteLine($"{studentsG2[i]}");
                }
            }
            else
            {
                Console.WriteLine("Please eneter 1 or 2");
            }
        }
    }
}