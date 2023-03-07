namespace Exercise06HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise06");
            // Create two variables and initialize them with a keyboard input
            // Write code that can test which number is larger
            // Write code that can test the numbers whether they are even or odd
            // Write the larger number from the two in the console
            // After that write if the number is even or odd

            Console.WriteLine("Enter the first number");
            string firstInput = Console.ReadLine();
            bool firstNumber = int.TryParse(firstInput, out int number1);
            //Console.WriteLine(number1);
            if (!firstNumber)
            {
                Console.WriteLine("Wrong input");
                return;
            }

            Console.WriteLine("Enter the second number");
            string secondInput = Console.ReadLine();
            bool secondNumber = int.TryParse(secondInput, out int number2);
           // Console.WriteLine(number2);
           if(!secondNumber)
            {
                Console.WriteLine("Wrong input");
                return;
            }

           if(number1 > number2)
            {
                Console.WriteLine($"{number1} is larger than {number2}");
            }else
            {
                Console.WriteLine($"{number2} is larger than {number1}");
            }

           if(number1 % 2 == 0)
            {
                Console.WriteLine($"{number1} is even");
            }else
            {
                Console.WriteLine($"{number1} is odd");
            }
            if (number2 % 2 == 0)
            {
                Console.WriteLine($"{number2} is even");
            }
            else
            {
                Console.WriteLine($"{number2} is odd");
            }

        }
    }
}