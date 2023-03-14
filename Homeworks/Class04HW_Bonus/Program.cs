namespace Class04HW_Bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bonus
            //Take a sentence as input and print its largest word

            string sentence = "Hello from SEDC academy, wish you lot's of luck this semester!";
            string[] words = sentence.Split(' ', ',', '!');
            int wordsLenght = 0;
            string word = "";
            foreach(string s in words)
            {
                if(s.Length > wordsLenght)
                {
                    wordsLenght = s.Length;
                    word = s;
                }
            }
            Console.WriteLine($"The longest word in the sentence is: {word}");
        }
    }
}