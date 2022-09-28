using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // задать 2 матрицы, найти произведение матриц

            // метод генерирует массив
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

            //// вывод на консоль двумерного массива
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


            // метод умножает матрицы

            int[,] GetMatrixMulti(int[,] array1, int[,] array2)
            {
                int[,] arrayMulti = new int[array1.GetLength(0), array2.GetLength(1)];
                int sum = 0;

                for (int i = 0; i < arrayMulti.GetLength(0); i++)
                {
                    for (int j = 0; j < arrayMulti.GetLength(1); j++)
                    {
                        for (int k = 0; k < arrayMulti.GetLength(1); k++)
                        {
                            sum = sum + (array1[i, k] * array2[k, j]);
                        }
                        arrayMulti[i, j] = sum;
                        sum = 0;
                    }
                    
                }
                return arrayMulti;
            }


            //генерируем 2 матрицы
            int[,] matrix1 = GetTwoDimArray(2, 2, 1, 5);
            int[,] matrix2 = GetTwoDimArray(2, 2, 1, 3);

            Console.WriteLine("Первая матрица: ");
            PrintArray(matrix1);

            Console.WriteLine("Вторая матрица: ");
            PrintArray(matrix2);

            int[,] matrixMulti = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
            if (matrix1.GetLength(0) != matrix2.GetLength(1))
            {
                Console.WriteLine("Размер матриц не позволяет сделать произведение");
            }
            else
            {
                matrixMulti = GetMatrixMulti(matrix1 , matrix2);
            }

            Console.WriteLine("Результат умножения матриц: ");

            PrintArray(matrixMulti);

        }
    }
}
