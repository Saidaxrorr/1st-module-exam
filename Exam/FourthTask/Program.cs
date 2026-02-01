namespace FourthTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("son kiriting: ");
            int NtaSon = int.Parse(Console.ReadLine());

            while (true)
            {
                for (int i = 0; i < NtaSon; i++)
                {
                    for (int d = 0; d < i; d++)
                    {
                        Console.Write("+");
                    }
                    Console.WriteLine();
                }
                var son = NtaSon - 2;

                for (int i = 0; i < NtaSon - 2; i++)
                {
                    for (int d = 0; d < son; d++)
                    {
                        Console.Write("+");
                    }
                    son--;
                    Console.WriteLine();
                }
            }

        }
    }
}
