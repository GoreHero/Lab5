using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 1000;
            int[] array = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, n);

                Console.Write("{0 } ", array[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (array[i] > array[j])
                    {
                        int t= array[i];
                        array[i] = array[j];
                        array[j] = t;  
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.ReadKey();
        }
    }
}