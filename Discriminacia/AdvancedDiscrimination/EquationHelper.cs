using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discriminant
{
    public static class EquationHelper
    {
        public static double CalculateD(double a, double b, double c)
        {
            return (b * b) - (4 * a * c);
        }

        public static int HowManySolution(double discriminant)
        {
            if (discriminant > 0)
            {
                return 2;
            }
            else if (discriminant < 0)
            {
                return 0;
            }
            else { return 1; }
        }

        public static double[] CalculateRoots(double a, double b, double c)
        {
            double discriminant = CalculateD(a, b, c);
            int rootCount = HowManySolution(discriminant);
            if (rootCount == 2)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                return new double[] { root1, root2 };
            }
            else if (rootCount == 1)
            {
                double root = -b / (2.0 * a);
                return new double[] { root };
            }
            else return new double[0];
        }
    }
}
