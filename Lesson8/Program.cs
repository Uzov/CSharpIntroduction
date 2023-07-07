/*
 Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
6 16
9 6

Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 
 */

namespace Lesson8
{
    static class Constants
    {
        public const bool Debug = false;
    }
    
    internal class Program
    {
        private static void Main()
        {
            Lesson8 challenge54 = new();
            Lesson8 challenge56 = new();
            Lesson8 challenge58 = new();
            Lesson8 challenge60 = new();

            List<List<int>> inputList = new() {
                new List < int >() { 1, 4, 7, 2 },
                new List < int >() { 5, 9, 2, 3 },
                new List < int >() { 8, 4, 2, 4 }
            };
            
            challenge54.SortRow(inputList);
            Console.WriteLine();
            
            challenge56.SumRow(inputList);
            Console.WriteLine();
            
            List<List<int>> firstList = new() {
                new List < int >() { 2, 4 },
                new List < int >() { 3, 2 }
            };
            
            List<List<int>> secondList = new() {
                new List < int >() { 3, 4 },
                new List < int >() { 3, 3 }
            };
            
            challenge58.Multiple(firstList, secondList);
            Console.WriteLine();

            challenge60.ThreeDim();
        }
    }
    internal class Lesson8
    {
        //Задача54
        public void SortRow(List<List<int>> inputList)
        {
            foreach (List<int> value in inputList) { 
                value.Sort(); 
                value.Reverse(); 
            };
            inputList.ForEach(p => { 
                p.ForEach(n => Console.Write($"{n} ")); 
                Console.WriteLine(); 
            });
        }

        //Задача56
        public void SumRow(List<List<int>> inputList)
        {
            List<int> sum = new List<int>();
            foreach (List<int> value in inputList) { 
                sum.Add(value.Sum()); 
                if (Constants.Debug) Console.WriteLine(value.Sum());
            };
            if (Constants.Debug) Console.WriteLine(sum.Min());
            Console.WriteLine($"Индекс строки с минимальной суммой: {sum.IndexOf(sum.Min())}");
            sum.Clear();
        }

        //Задача58
        public void Multiple(List<List<int>> firstList, List<List<int>> secondList)
        {
            var multiplyList = firstList.Zip(secondList, (first, second) => first.Zip(second, (firstone, secondone) => firstone * secondone));
            multiplyList.ToList().ForEach(p => { p.ToList().ForEach(n => Console.Write($"{n} ")); Console.WriteLine(); });
        }

        //Задача60
        /*
         66(0,0,0) 25(0,1,0)
         34(1,0,0) 41(1,1,0)
         27(0,0,1) 90(0,1,1)
         26(1,0,1) 55(1,1,1)
         */

        public void ThreeDim()
        {
            List<int> ints = new List<int>() {66, 27, 25, 90, 34, 26, 41, 55 };
            var chunk4 = ints.Chunk(ints.Count/2);
            Console.WriteLine();
            foreach (var chunk in chunk4) {
                foreach (var chunk2 in chunk)
                {
                    //Console.WriteLine(chunk2);
                }
            };

            int[,,] array3D = new int[2, 2, 2] { { { 66, 27 }, { 25, 90 } }, { { 34, 26 }, { 41, 55 } } };
            Console.WriteLine("Проверка правильности задания массива:");
                Console.Write($"{array3D[0, 0, 0]}(0,0,0)=66 ");
            Console.WriteLine($"{array3D[0, 1, 0]}(0,1,0)=25 ");
                Console.Write($"{array3D[1, 0, 0]}(1,0,0)=34 ");
            Console.WriteLine($"{array3D[1, 1, 0]}(1,1,0)=41 ");
                Console.Write($"{array3D[0, 0, 1]}(0,0,1)=27 ");
            Console.WriteLine($"{array3D[0, 1, 1]}(0,1,1)=90 ");
                Console.Write($"{array3D[1, 0, 1]}(1,0,1)=26 ");
            Console.WriteLine($"{array3D[1, 1, 1]}(1,1,1)=55 ");
            Console.WriteLine("Вывод массива в нужной последовательности:");
            for (int z=0; z<2; z++)
            {
                for (int x=0; x<2; x++)
                {
                    for (int y = 0; y < 2; y++)
                    {
                        if (y==1) Console.WriteLine($"{array3D[x, y, z]}({x},{y},{z}) ");
                        else Console.Write($"{array3D[x, y, z]}({x},{y},{z}) ");

                    }
                }
            }

        }

        //Печать двумерного массива
        private static void PrintArray(int[,] arr)
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
