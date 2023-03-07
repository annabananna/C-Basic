namespace Class_2_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Real calculator");
            // Create new console application “RealCalculator” that takes two numbers from the input and asks what operation 
            // would the user want to be done( +, - , * , / ). Then it returns the result.

            Console.WriteLine("Enter the first number");
            string firstNumber = Console.ReadLine();
            if(!double.TryParse(firstNumber, out double number1))
            {
                Console.WriteLine("Wrong input");
                return;
            }

            Console.WriteLine("Enter the second number");
            if(!double.TryParse(Console.ReadLine(),out double number2)) {
                Console.WriteLine("Wrong input");
                return;
            }

            Console.WriteLine("Enter the operation");
            string op = Console.ReadLine();

            if(op == "+")
            {
                Console.WriteLine(number1 + number2);
            }
            else if (op == "-")
            {
                Console.WriteLine(number1 - number2);
            }
            else if (op == "*")
            {
                Console.WriteLine(number1 * number2);
            }
            else if (op == "/")
            {
                Console.WriteLine(number1 / number2);
            }
            else
            {
                Console.WriteLine("Please enter valid operation");
            }

        }
    }
}