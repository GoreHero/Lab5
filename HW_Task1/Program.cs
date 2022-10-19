using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Task1
{
    internal class Program
    {
        //Сформировать одномерный массив из 7 элементов.
        //Заполнить массив числами, вводимыми с клавиатуры, определить среднее арифметическое элементов.
        static void Main(string[] args)
        {
            const int n = 7; float sum = 0;
            int[] list7 = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                Console.Write("Ввод: ");
                list7[i] = Convert.ToInt32(Console.ReadLine());
                sum += list7[i];
            }
            Console.Write("[");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0,3}", list7[i]); 
            }
            Console.Write(" ] среднее арифметическое массива = ");
            Console.WriteLine("{0:f2} ", sum/n); Console.ReadKey();


        }
    }
}
