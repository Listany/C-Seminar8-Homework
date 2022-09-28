using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task001
{
    internal class Program

        


         
    {
        static void Main(string[] args)
        {
            //Программа упорядочивает по убыванию каждую строку двумерного массива


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

            // метод печати двумерного массива

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

            int[,] myArray = GetTwoDimArray(5, 5, 1, 10);

            Console.WriteLine("Первый массив");
            PrintArray(myArray);

                         

            // метод пузырька двумерный


            int[,] GetTwoDimBubbleSort(int[,] array)
            {
                int tmp = 0;

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = 1; k < array.GetLength(1); k++)
                        {
                            if (array[j, k] > array[j, k-1])
                            {
                                tmp = array[j, k - 1];
                                array[j, k - 1] = array[j, k];
                                array[j, k] = tmp;
                            }
                        }
                    }
                }
                return array;
            }

            myArray = GetTwoDimBubbleSort(myArray);

            Console.WriteLine("Отсортированный массив");

            PrintArray(myArray);
        }
    }
}
