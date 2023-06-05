using System.Security.Cryptography.X509Certificates;

namespace Discriminant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = UserInteractionHelper.Inputer("a");
            double b = UserInteractionHelper.Inputer("b");
            double c = UserInteractionHelper.Inputer("c");

            EquationHelper.CalculateD(a, b, c);

        }
    }
}
