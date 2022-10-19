using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int s = 0;
            int k = 0;
            for (int i= 0; i < 10; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                if (array[i]%2 == 0)
                {
                    s += array[i];
                    k++;
                }

            }
            Console.WriteLine(((double)s)/k);
            Console.ReadKey();
        }
    }
}
