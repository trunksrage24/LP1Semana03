using System;

namespace ArraySums
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("insert number for columns and rows: ");
            int dim = Convert.ToInt32(Console.ReadLine());
            int[ , ] matrix = new int [dim, dim];
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine("nr pos (" + i + ", " + j + ")");
                    int input = Console.Read();
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}