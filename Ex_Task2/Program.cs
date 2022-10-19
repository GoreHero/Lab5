using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Размерность?: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        array[i, j] = ((i == j) || (i + j == n - 1)) ? 1 : 0;
                        Console.Write("{0} ", array[i,j]);
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }
    }
}
