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

            int numSolutions = EquationHelper.HowManySolution(discriminant);
            if (numSolutions == 1)
            {
                double root = EquationHelper.CalculateSingleRoot(a, b);
                Console.WriteLine("1 Root");
                Console.WriteLine($"Root = {root}");
            }
            else if (numSolutions == 2)
            {
                double[] roots = EquationHelper.CalculateTwoRoots(a, b, discriminant);
                Console.WriteLine("2 Roots");
                Console.WriteLine($"First Root = {roots[0]}");
                Console.WriteLine($"Second Root = {roots[1]}");
            }
            else
            {
                Console.WriteLine("Discriminant is negative, there are no Roots");
            }

        }

    }
}
