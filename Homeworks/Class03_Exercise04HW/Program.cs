using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Xml.Linq;

namespace Exercise04HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays HW");

            //Declare 5 arrays with 5 elements in them:
            // With words
            // With decimal values
            // With characters from keyboard
            // With true / false values
            // With arrays, each holding 2 whole numbers

            string[] stringArray = new string[5] { "arr1", "arr2", "arr3", "arr4", "arr5" };
            double[] doubleArray = new double[5] { 11.1, 22.2, 33.3, 44.4, 55.5 };

            char[] charArray = new char[0];
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter a char");
                string input = Console.ReadLine();
                Array.Resize(ref charArray, charArray.Length + 1);
                char character = char.Parse(input);
                charArray[charArray.Length - 1] = character;
            }
            foreach(char character in charArray)
            {
                Console.WriteLine(character);
            }

            bool[] boolArray = new bool[5];
            boolArray[0] = true;
            boolArray[1] = false;
            boolArray[2] = true;
            boolArray[3] = false;
            boolArray[4] = true;

            Console.WriteLine(boolArray[0]);

            int[,] arrayOfArrays = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

        }
    }
}


