using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Сформировать трехмерный массив двухзначных чисел, 
            // Программа построчно выводит массив и его индексы

            
            // метод генерирует массив
            int[,,] GetThreeDimArray(int sizeA, int sizeB, int sizeC)
            {
                int[,,] array = new int[sizeA, sizeB, sizeC];

                var random = new Random();

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = 0; k < array.GetLength(2); k++)
                        {
                            array[i, j, k] = random.Next(1, 100);
                        }
                    }
                }
                return array;
            }

            // метод выводит на печать + индексы

            void PrintArrayIndex(int[,,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    Console.WriteLine($"Страница {i}");
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = 0; k < array.GetLength(2); k++)
                        {
                            Console.Write(array[i, j, k] + "\t" + $"  индексы ({i},{j},{k})");

                        }
                        Console.WriteLine();
                    }
                    
                }
            }


            int[,,] myArray = GetThreeDimArray(2, 2, 2);

            PrintArrayIndex(myArray);

        }
    }
}
