using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Bank
    {
        private string AccountHolder;
        private int AccountNumber;
        private double Balance;

        public Bank(string AccHold , int AccNum , double Bal)
        {
            AccountHolder = AccHold;
            AccountNumber = AccNum;
            Balance = Bal;
        }

        public void Deposit(double x)
        {
            Balance = Balance + x;
        }

        public void Withdraw(double y)
        {
            if(y > Balance)
            {
                Console.WriteLine("Insufficient Funds");
                Console.WriteLine("\n");
            }
            else
            {
                Balance = Balance - y;
                Console.WriteLine("\n");
                Console.WriteLine("You Withdrew R" + y);
                Console.WriteLine("\n");
            }
        }

        public double getBalance()
        {
            return Balance;
        }

    }
}
