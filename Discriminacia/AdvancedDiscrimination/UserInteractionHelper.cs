using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Discriminant
{
    public class UserInteractionHelper
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
        public static void Output(double a, double b, double c)
        {
            double discriminant = EquationHelper.CalculateD(a, b, c);
            Console.WriteLine("The discriminant is: " + discriminant);

            double[] roots = EquationHelper.CalculateRoots(a, b, c);
            if (roots.Length == 1)
            {
                Console.WriteLine("1 Root");
                Console.WriteLine("Root: " + roots[0]);
            }
            else if (roots.Length == 2)
            {
                Console.WriteLine("2 Roots");
                Console.WriteLine("Root 1: " + roots[0]);
                Console.WriteLine("Root 2: " + roots[1]);
            }
            else
            {
                Console.WriteLine("No Roots found!");
            }
        }
    }
}
