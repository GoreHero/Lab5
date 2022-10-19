using System;

namespace HW_Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Размер массива: ");
            int n =  Convert.ToInt32(Console.ReadLine());
            int[,] list = new int[n,n];

            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    list[i, j] = 0;
                }                
            } // 0
            for (int i = 0; i < n; i += 2)
            {
                for (int j = 1; j < n; j += 2)
                    list[i, j] = 1;                
            } //0 1

            for (int i = 1; i < n; i+=2)
            {
                for (int j = 0; j < n; j += 2)                
                    list[i, j] = 1;                
            } //1 0
            
            for (int k = 0; k < n; k++)
            {
                for (int l = 0; l < n; l++)                
                    Console.Write("{0} ", list[k, l]);                
                Console.WriteLine();
            }
        }
    }
}
