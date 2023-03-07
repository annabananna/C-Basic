namespace Exercise03HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare an integer and a string variable
            //Initialize them and concatenate them in a new variable
            //Print the result in the console

            int number = 10;
            string word = "homework";
            string result = number .ToString() + word ;
            //string result2 = number + word;
            Console.WriteLine(result);
        }
    }
}