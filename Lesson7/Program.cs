/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого 
элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7->такого числа в массиве нет
1, 2 -> 2

Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.
*/

#pragma warning disable IDE0071, CA1822

namespace Lesson7
{
    internal class Program
    {
        private static void Main()
        {
            Lesson7 challenge47 = new ();
            challenge47.RndArray(3, 4);
            challenge47.RndArray(5, 8);
            challenge47.RndArray(10, 10);
            challenge47.RndArray(2, 5);

            Lesson7 challenge50 = new ();
            challenge50.FindElement(1, 1);
            challenge50.FindElement(2, 3);
            challenge50.FindElement(10, 3);
            challenge50.FindElement(0, 0);
            challenge50.FindElement(3, 3);

            Lesson7 challenge52 = new ();
            int[,] inputArray = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
            challenge52.FindAverageRow(inputArray);
            challenge52.FindAverageRow(new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } });
            Console.WriteLine();
            challenge52.FindAverageCol(inputArray);
            challenge52.FindAverageCol(new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } });
        }
    }
    internal class Lesson7 {    
        //Задача 47
        public void RndArray(int m = 3, int n = 4)
        {
            float[,] inputArray = new float[m, n];
            var _random = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    inputArray[i, j] = (float)_random.NextDouble() * _random.Next(-100, 100);
                }
             }
            PrintArray(inputArray);
        }
        //Задача 50
        public void FindElement(int m, int n)
        {
            int[,] inputArray = new int [3,4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
            try
            {
                Console.WriteLine($"Элемент массива [{m},{n}] равен {inputArray[m, n]}"); 
                Console.WriteLine();
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.Write($"Элемент [{m},{n}] отсутствует! Trace: \"");
                Console.WriteLine($"{exception.ToString()}\"");
                Console.WriteLine();
            }
        }
        //Задача 52
        //Среднее по строкам
        public void FindAverageRow(int[,] arr)
        {
            int m = arr.GetLength(0);//Число строк массива
            int n = arr.GetLength(1);//Число столбцов массива
            int avg;
            Console.Write("Средние значения по строкам: ");
            for (int i = 0; i < m; i++)
            {
                avg = 0;
                for (int j = 0; j < n; j++)
                {
                    avg += arr[i, j];
                }
                Console.Write($"{((float)avg / n).ToString()} ");    
            }
            Console.WriteLine();
        }
        //Среднее по столбцам
        public void FindAverageCol(int[,] arr)
        {
            int m = arr.GetLength(0);//Число строк массива
            int n = arr.GetLength(1);//Число столбцов массива
            int avg;
            Console.Write("Средние значения по столбцам: ");
            for (int i = 0; i < n; i++)
            {
                avg = 0;
                for (int j = 0; j < m; j++)
                {
                    avg += arr[j, i];
                }
                Console.Write($"{Math.Round(((float)avg / m), 1).ToString()} ");
            }
            Console.WriteLine();
        }
        //Печать массива
        private static void PrintArray(float [,] arr)
        {
            int m = arr.GetLength(0);//Число строк массива
            int n = arr.GetLength(1);//Число столбцов массива
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                    if (j == n - 1) Console.WriteLine();
                }
                if (i == m - 1) Console.WriteLine();
            }
        }

    }
}