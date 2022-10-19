using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Task4
{
    internal class Program
    {
        //Cформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50].
        //Определить количество   нечетных положительных элементов, стоящих на четных местах.

        static void Main(string[] args)
        {
            const int n = 20;
            int[] list = new int[n];
            int count = 0;
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                list[i] = random.Next(-50, 50);
            } //формируем масив

            for (int i = 1; i < n; i += 2)
            {
                if ((list[i] > 0) && ((list[i] % 2) !=  0))
                {
                    count++;
                }
            }
            foreach (int i in list)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine("количество нечетных положительных элементов, стоящих на четных местах = {0}", count);
        }
    }
}
