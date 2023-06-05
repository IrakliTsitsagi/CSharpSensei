using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discriminant
{
    internal static class UserInteractionHelper
    {
        public static double Inputer(string abc)
        {
            double number;
            bool isNumber;
            do
            {
                Console.WriteLine($"Enter number {abc}");
                string input = Console.ReadLine();
                isNumber = double.TryParse(input, out number);
                if (!isNumber)
                {
                    Console.WriteLine("Input is not an integer");
                }

            } while (!isNumber);
            return number;

        }
    }
}