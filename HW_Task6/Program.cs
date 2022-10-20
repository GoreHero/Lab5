using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Task6
{
    internal class Program
    {
        //Запросить у пользователя целочисленное значение N.
        //Сформировать двумерный массив размера NxN.
        //Заполнить массив числами, вводимыми с клавиатуры.
        //Проверить, является ли введенная с клавиатуры матрица магическим квадратом.
        //Магическим квадратом называется матрица, сумма элементов которой в каждой строке, в каждом столбце и по каждой диагонали одинакова.

        static void Main(string[] args)
        {
            Console.Write("размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sumMain = 0;
            int sumSide = 0;
            int sumHoriz = 0;
            int sumVert = 0;

            bool flag = false;

            string Success = "Магия!";
            string Fail = "Не магия!";

            int[,] matrix = new int[n, n];

            #region создание и заполнение массива
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            #endregion
            #region вывод массива
            Console.WriteLine("Массив: ");  //вывожу массив
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            #endregion
            #region получение суммы диагоналей
            for (int i = 0; i < n; i++)
            {
                sumMain += matrix[i, i];
            }
            for (int i = 0; i < n; i++)
            {
                sumSide += matrix[i, n - i - 1];
            }
            #endregion

            if (sumMain == sumSide)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        sumHoriz += matrix[i, j];
                    }
                    for (int k = 0; k < n; k++)
                    {
                        sumVert += matrix[k, i];
                    }
                    if ((sumHoriz == sumSide) && (sumVert == sumSide))
                    {
                        flag = true;
                        sumHoriz = 0;
                        sumVert = 0;
                    }
                    else
                        flag = false;
                    break;
                }

            }
            else
                flag = false;

            if (flag == true)
                Console.WriteLine(Success);
            else
                Console.WriteLine(Fail);
            Console.ReadKey();
        }
    }
}
