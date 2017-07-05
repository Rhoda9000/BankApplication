using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string AccHold;
            int AccNum;

            Console.WriteLine("What is The Account Holder's Name? ");
            AccHold = Console.ReadLine();

            Console.WriteLine("Enter Bank Account Number");
            AccNum = int.Parse(Console.ReadLine());

            Bank Account = new Bank(AccHold, AccNum, 0.00);

            Console.WriteLine("\n");

            bool exit = true;
            while (exit)
            {
                Console.WriteLine("Welcome To Basic Bank Application");
                Console.WriteLine("1.Check Balance");
                Console.WriteLine("2.Deposit");
                Console.WriteLine("3.Withdraw");
                Console.WriteLine("4.Display Account Details");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Select an option");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("\n");
                        Console.WriteLine("Your Balance is R" + Account.getBalance());
                        Console.WriteLine("\n");
                        break;

                    case 2:
                        Console.WriteLine("How Much Do You Want To Deposit?");
                        double x = double.Parse(Console.ReadLine());
                        Account.Deposit(x);
                        Console.WriteLine("\n");
                        Console.WriteLine("You Have Deposited R" + x);
                        Console.WriteLine("\n");
                        break;

                    case 3:
                        Console.WriteLine("How Much Do You Want To Withdraw?");
                        double y = double.Parse(Console.ReadLine());
                        Account.Withdraw(y);                       
                        Console.WriteLine("\n");
                        break;

                    case 4:
                        Console.WriteLine("\n");
                        Console.WriteLine("Account Holder's Name: " + AccHold + "\n" + "Account Number:" + AccNum + "\n" + "Balance: R" + Account.getBalance());
                        Console.WriteLine("\n");
                        break;


                    case 5:
                        exit = false;
                        Console.WriteLine("\n");
                        Console.WriteLine("Goodbye " + AccHold);
                        break;

                    default:
                        Console.WriteLine("\n");
                        Console.WriteLine("Invalid option");
                        Console.WriteLine("\n");
                        break;
                }
            }
        }
    }
}
