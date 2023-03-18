namespace Class04_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //Take one string from the input and print its last 5 characters.

            Console.WriteLine("Please enter a string");

            string output = Console.ReadLine();
            int n = 5;

            if(n > output.Length)
            {
                Console.WriteLine($"Can't print last 5 characters, the input {output} is less than 5 characters");
                return;
            }

            string substring = output.Substring(output.Length - 5);
            Console.WriteLine(substring);

            //Task 2
            //Take a sentence as input and print its words.

            string sentence = "Saying hello from SEDC academy!";
            string[] words = sentence.Split( ' ', '!' );
            for(int i = 0; i < words.Length; i++)
            {
                Console.WriteLine($"{words[i].Trim()}");
            }

        }
    }
}
