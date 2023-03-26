using System.Net;
using System.Reflection.Metadata;

namespace Class06_ATM_HW
{
    public class BankAccount
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public long CardNumber { get; set; }
        private int Pin { get; set; }
        private double Balance { get; set; }


        public BankAccount(string name, string lastname, long cardNumber, int pin, double balance)
        {
            Name = name;
            LastName = lastname;
            CardNumber = cardNumber;
            Pin = pin;
            Balance = balance;

        } 

        public bool CorrectCardNumber(long cardNumber)
        {
            return CardNumber == cardNumber;
        }

        public bool CorrectPin(int pin)
        {
            return Pin == pin;
        }

        public string GreetingMessage()
        {
            return $"Welcome {Name} {LastName}!\nWhat would you like to do:\n\t1. Check Balance\n\t2. Cash Withdrawal\n\t3. Cash Deposit";
        }
        public string ThankYouMessage()
        {
            return $"Thank you {Name} {LastName} for using our servises!";
        }

        public double GetBalance()
        {
            return Balance;
        }
    }
}
