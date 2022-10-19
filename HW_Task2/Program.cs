using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Task2
{
    internal class Program
    {
        //Сформировать одномерный массив из 15 элементов,
        //которые выбираются случайным образом из диапазона[0; 50].
        //Определить сумму максимального и минимального элементов массива

        static void Main(string[] args)
        {
            const int n = 15; int Max = -1; int Min = 51;

            int[] List15 = new int[n];

            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                List15[i] = random.Next(0, 50);
                Console.Write("{0,3}", List15[i]) ;
                Max = (Max < List15[i]) ? List15[i] : Max;
                Min = (Min > List15[i]) ? List15[i] : Min;

            }
            Console.WriteLine();
            Console.WriteLine("MAX= {0}", Max);
            Console.WriteLine("MIN= {0}", Min);
            Console.ReadKey();
        }
    }
}
