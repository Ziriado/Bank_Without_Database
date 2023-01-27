using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_No_Database.Methods
{
    internal class Outputs
    {
        public static void ShowBalance(double balance)
        {
            Console.WriteLine("Your current balance is: " + balance + " SEK");
        }

        private static double LowerBalance(double balance, double withdraw)
        {
            balance = balance - withdraw;
            return balance;
        }
        public static double IncreaseBalance(double balance, double deposit)
        {

            balance = balance + deposit;
            return balance;
        }
        public static double GetInputBalanceWithdraw(double balance)
        {
            double withdraw = 0;
            ShowBalance(balance);
            Console.Write("Enter the amount you wish to withdraw: ");

            withdraw = Helpers.TryNumber(withdraw, balance, 0);

            balance = LowerBalance(balance, withdraw);

            return balance;
        }
        public static double GetInputDeposit(double balance)
        {
            double deposit = 0;
            Console.Write("Enter the amount you wish to deposit: ");
            deposit = Helpers.TryNumber(deposit, 0);
            if (deposit > 10000)
            {
                Console.WriteLine("You can only deposit 10 000 SEK");
            }
            else
            {
                balance = IncreaseBalance(balance, deposit);
                Console.WriteLine("Your current balance is: " + balance + " SEK");

            }

            return balance;


        }
    }
}
