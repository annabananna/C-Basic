using System.Reflection;

namespace Exercise04HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise04");
            //You have n credits on your mobile bill. One SMS costs m credits.
            //How many SMS messages you can send ?
            //n = 102
            //m = 5
            //Result = ?

            int credits = 102;
            int smsToCredit = 5;

            int result = credits / smsToCredit;
            Console.WriteLine(result);

        }
    }
}