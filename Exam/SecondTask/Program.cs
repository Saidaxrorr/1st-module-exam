using System.Runtime.Serialization;

namespace SecondTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number2 = int.Parse(Console.ReadLine()!);
            int sum = 0;
            for (int i = 1; i <= number2; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.Write(i + "+");
                    sum += i;
                }
            }
            Console.WriteLine("\b" + " = " + sum);
        }
    }
}
