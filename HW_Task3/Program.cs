using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Task3
{
    internal class Program
    {
        //Сформировать одномерный массив из 10 случайных чисел в диапазоне[-50;50].
        //Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.

        static void Main(string[] args)
        {
            const int n = 10;
            int[] List10 = new int[n];

            Random random = new Random();

            for (int i = 0; i < n; i++)
                List10[i] = random.Next(-50, 50);

            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j <= n / 2; j++)
                {
                    if (List10[i] < List10[j])
                    {
                        int t = List10[i];
                        List10[i] = List10[j];
                        List10[j] = t;
                    }
                }
            }
            for (int i = n / 2 ; i < n; i++)
            {
                for (int j = n / 2; j < n; j++)
                {
                    if (List10[i] >= List10[j])
                    {
                        int t = List10[i];
                        List10[i] = List10[j];
                        List10[j] = t;
                    }
                }
            }


            /*for (int i = 0; i < n; i++)
                Console.Write("{0} ", List10[i]);
            */
            foreach (int i in List10)
            {
                Console.Write($"{i} ");
            }

            Console.ReadKey();

        }
    }
}