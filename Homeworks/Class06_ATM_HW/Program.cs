using System.Globalization;
using System.Security;
using System.Xml.Linq;

namespace Class06_ATM_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount[] bankAccounts = new BankAccount[3];

            BankAccount bankAccount1 = new BankAccount("John", "Doe", 1234123412341234, 1111, 500);
            bankAccounts[0] = bankAccount1;
            bankAccounts[1] = new BankAccount("Bob", "Bobski", 4321432143214321, 7896, 2000);
            bankAccounts[2] = new BankAccount("Jull", "Julski", 9876987698769876, 5555, 3500);

            while(true)
            {
                string input;
                while (true)
                {
                    Console.WriteLine("Please choose an option\n\t1. Log-in\n\t2. Register");

                    input = Console.ReadLine();

                    if (input == "1" || input == "2")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("We only support options 1 & 2, so please choose one of them");
                    }

                }
                if(input == "1")
                {
                    Console.WriteLine("Welcome to the ATM app.\nPlease enter your card number: ");
                    string cardNumber = Console.ReadLine();
                    cardNumber = cardNumber.Replace("-", "");
                    long cardNumber1 = long.Parse(cardNumber);
                    Console.WriteLine("Enter pin:");
                    string pin = Console.ReadLine();
                    int pin1 = int.Parse(pin);

                    long inputCard = 0;
                    int inputPin = 0;
                    BankAccount foundBankAccount = null;

                    foreach (BankAccount b in bankAccounts)
                    {
                        if(b.CorrectCardNumber(cardNumber1) && b.CorrectPin(pin1))
                        {
                            inputCard = cardNumber1;
                            inputPin = pin1;
                            foundBankAccount = b;
                            break;
                        }
                    }
                    if(foundBankAccount == null)
                    {
                        Console.WriteLine("No card found!");
                    }
                    else
                    {

                        double deposit = 0;
                        double withdraw = 0;
                        double currentBalance = foundBankAccount.GetBalance();
                        while (true)
                        {
                            Console.WriteLine(foundBankAccount.GreetingMessage());
                            input = Console.ReadLine();
                            if (input == "1")
                            {
                                Console.WriteLine($"Your current Balance is : {currentBalance.ToString("C", new CultureInfo("en-US"))}");
                                Console.WriteLine("Would you like to make another transaction? Enter Y to make another transaction");
                                string input1 = Console.ReadLine();
                                if (input1.ToLower() == "Y".ToLower())
                                {
                                    continue;
                                }
                                else if (input1.ToLower() != "Y".ToLower())
                                {
                                    Console.WriteLine(foundBankAccount.ThankYouMessage());
                                    break;
                                }
                            }
                            else if (input == "2")
                            {
                                Console.WriteLine("Please enter the amount you would like to withdraw");
                                withdraw = double.Parse(Console.ReadLine());
                                if (withdraw > currentBalance)
                                {
                                    Console.WriteLine("You dont have enough money!");
                                    Console.WriteLine(foundBankAccount.ThankYouMessage());
                                    break;
                                }
                                else
                                {

                                    currentBalance -= withdraw;
                                    Console.WriteLine($"You have withdrawn {withdraw.ToString("C", new CultureInfo("en-US"))} and you current balance is {currentBalance.ToString("C", new CultureInfo("en-US"))}");
                                    Console.WriteLine("Would you like to make another transaction? Enter Y to make another transaction");
                                    string input1 = Console.ReadLine();
                                    if (input1.ToLower() == "Y".ToLower())
                                    {
                                        continue;
                                    }
                                    else if (input1.ToLower() != "Y".ToLower())
                                    {
                                        Console.WriteLine(foundBankAccount.ThankYouMessage());
                                        break;
                                    }
                                }
                            }
                            else if (input == "3")
                            {
                                Console.WriteLine("Please enter the amount you would like to deposit");
                                deposit = double.Parse(Console.ReadLine());
                                currentBalance += deposit;
                                Console.WriteLine($"You have deposit {deposit.ToString("C", new CultureInfo("en-US"))} and you current balance is {currentBalance.ToString("C", new CultureInfo("en-US"))}");
                                Console.WriteLine("Would you like to make another transaction? Enter Y to make another transaction");
                                string input1 = Console.ReadLine();
                                if (input1.ToLower() == "Y".ToLower())
                                {
                                    continue;
                                }
                                else if (input1.ToLower() != "Y".ToLower())
                                {
                                    Console.WriteLine(foundBankAccount.ThankYouMessage());
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter valid option!");
                            }
                        }
                    }
                }
                else if(input == "2")
                {
                    
                    Console.WriteLine("Please enter your name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Please enter your last name");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Please enter your credit card");
                    if (!(long.TryParse(Console.ReadLine(), out long cardNumberInput)))
                    {
                        Console.WriteLine("Please enter valid card number");
                        break;
                    }
                    Console.WriteLine("Please enter your pin");
                    if (!int.TryParse(Console.ReadLine(), out int pinInput))
                    {
                        Console.WriteLine("Enter a valid pin");
                        break;
                    }

                    BankAccount newBankAccount = new BankAccount(name, lastName, cardNumberInput, pinInput, balance: 0);
                    Array.Resize(ref bankAccounts, bankAccounts.Length + 1);
                    bankAccounts[bankAccounts.Length - 1] = newBankAccount;
                }
            }
 
        }
    }
}

