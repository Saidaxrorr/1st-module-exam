namespace ThirdTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Son kiriting:");
            var number1 = int.Parse(Console.ReadLine()!);
            var second = number1;
            if (number1 > 0)
            {
                for (int i = 0; i < number1; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write(number1);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
