namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 1;
            int num3;

            Console.WriteLine("enter number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            for (int i = 2; i < number; i++)
            {
                num3 = num1 + num2;
                Console.WriteLine(num3);
                num1 = num2;
                num2 = num3;
                if (num1 + num2 >= number)
                    break;
            }
        }
    }
}
