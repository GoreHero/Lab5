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
            int[] array = new int[10];
            Random random = new Random();
            int s = 0;
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(0, 10);
                s += array[i];
                Console.Write("{0 } ", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
