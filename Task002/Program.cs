using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Найти в двумерном массиве строку с наименьшей суммой элементов

            // генерируем массив
            int[,] GetTwoDimArray(int sizeA, int sizeB, int start, int end)
            {
                int[,] array = new int[sizeA, sizeB];

                var random = new Random();

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = random.Next(start, end);
                    }
                }
                return array;
            }


            // вывод на консоль двумерного массива
            void PrintArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }


            // двумерный массив

            int[,] myArray = GetTwoDimArray(3, 3, 1, 10);

            // одномерный массив для сумм строк

            int[] sumArray = new int[myArray.GetLength(0)];

            int sum = 0;

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    sum = sum + myArray[i, j];
                }
                sumArray[i] = sum;
                sum = 0;
            }

            // в одномерном массиве находим минимальный элемент

            int min = sumArray[0];

            for (int i = 1; i < sumArray.Length; i++)
            {
                if (sumArray[i] < min)
                {
                    min = i;
                }
                
            }

            PrintArray(myArray);

            Console.WriteLine($"Строка с наименьшей суммой элементов в массиве под номером {min + 1}");


        }
    }
}
