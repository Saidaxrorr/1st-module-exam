using System.Runtime.InteropServices;

namespace FiveTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = {19, 349, 494, 49};
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
            //Console.WriteLine();
            //Console.WriteLine(array[0]);

            //array[4] = 101;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            //Console.WriteLine(array[2]);

            var stringArrays = new string[10];
            Console.WriteLine(stringArrays[0]);
            int[,] twoDementional = new int[4, 6];

            //for (int i = 0; i < twoDementional.GetLength(0); i++)
            //{
            //    for (int j = 0; j < twoDementional.GetLength(1); j++)
            //    {
            //        Console.WriteLine(twoDementional[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            twoDementional[2, 5] = 5;
            twoDementional[1, 2] = 7;

            for (int i = 0; i < twoDementional.GetLength(0); i++) // rows
            {
                for (int j = 0; j < twoDementional.GetLength(1); j++) // columns
                {
                    Console.Write(twoDementional[i, j] + " ");
                }
                Console.WriteLine(); // new row

            }


            int[,,] threeD = new int[2, 3, 4];
            threeD[1, 1, 3] = 9;
            for (int sh = 0; sh < threeD.GetLength(0); sh++) // layers
            {
                Console.WriteLine($"Layer {sh}:");
                for (int j = 0; j < threeD.GetLength(1); j++) // rows
                {
                    for (int k = 0; k < threeD.GetLength(2); k++) // columns
                    {
                        Console.Write(threeD[sh, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }



        }
    }
}
