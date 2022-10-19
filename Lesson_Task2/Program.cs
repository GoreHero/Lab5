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
            bool flag = false;
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(0, 10);
                
                Console.Write("{0 } ", array[i]);
            }
            foreach (int a in array)
            {
                if (a == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Элемент найден");
                    flag = true;
                    break;
                }
                    
            }
            Console.WriteLine();
            if (!flag)
                Console.WriteLine("Элемент не найден");
            
            Console.ReadKey();

        }
    }
}
//O(log2)