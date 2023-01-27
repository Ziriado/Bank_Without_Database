using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bank_No_Database.Methods
{
    internal class Menus
    {
        enum MainMenu 
        {
            Show_Balance = 1,
            Depoist,
            Withdraw,
            Exit = 0
        }

        public static void RunProgram()
        {
            bool run = true;
            double balance = 0;
            while (run)
            {
          
                foreach (int i in Enum.GetValues(typeof(MainMenu)))
                {
                    Console.WriteLine($"{i}. {Enum.GetName(typeof(MainMenu), i).Replace('_', ' ')}");
                }
                int nr;
                MainMenu menu = (MainMenu)99;
                if (int.TryParse(Console.ReadKey(true).KeyChar.ToString(), out nr))
                {
                    menu = (MainMenu)nr;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
                switch (menu)
                {
                    case MainMenu.Show_Balance:
                        Outputs.ShowBalance(balance);
                        break;
                    case MainMenu.Depoist:
                     balance= Outputs.GetInputDeposit(balance);
                        break;
                    case MainMenu.Withdraw:
                        balance=Outputs.GetInputBalanceWithdraw(balance);
                        break;
                    case MainMenu.Exit:
                        run = false;
                        break;
                }
            }
        }
    }
}
