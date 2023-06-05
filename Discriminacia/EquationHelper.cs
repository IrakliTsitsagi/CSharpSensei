using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discriminant
{
    public static class EquationHelper
    {
        public static void CalculateD(double a, double b, double c)
        {
            double discriminant = (b * b) - (4 * a * c);
            Console.WriteLine("The discriminant is: " + discriminant);
            if (discriminant == 0)
            {
                double x1 = -b / (2.0 * a);
                Console.WriteLine($"Root = {x1}");
            }
            else if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                Console.WriteLine($"First Root = {x1}");
                Console.WriteLine($"Second Root = {x2}");
            }
            else
                Console.WriteLine("Root are imeainary;\nNo Solution. ");

        }
    }
}
