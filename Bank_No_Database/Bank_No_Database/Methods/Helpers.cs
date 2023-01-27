using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_No_Database.Methods
{
    public class Helpers
    {
        public static double TryNumber(double number, double maxValue, double minValue)
        {
            bool correctInput = false;
            while (!correctInput)
            {
                if (!double.TryParse(Console.ReadLine(), out number) || number > maxValue || number < minValue)
                {
                    Console.WriteLine("Wrong input!");
                    Outputs.ShowBalance(maxValue);
                    Console.Write("Try again: ");
                }
                else
                {
                    correctInput = true;
                }
            }
            return number;
        }
        public static double TryNumber(double number, double minValue)
        {
            bool correctInput = false;
            while (!correctInput)
            {
                if (!double.TryParse(Console.ReadLine(), out number) || number < minValue)
                {
                    Console.WriteLine("Wrong input!");
                    Outputs.ShowBalance(number);
                    Console.Write("Try again: ");
                }
                else
                {
                    correctInput = true;
                }
            }
            return number;
        }
    }
}
