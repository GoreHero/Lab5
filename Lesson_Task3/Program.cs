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
            int[] array = new int[100];
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(0, 10);

                Console.Write("{0 } ", array[i]);
            }
            Console.WriteLine();
            int max = array[0];
            foreach (int a in array)
            {
                if (a > max)
                    max = a;


            }
            Console.WriteLine(max);
            Console.ReadKey();

        }
    }
}