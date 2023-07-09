﻿/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 9
m = 2, n = 3 -> A(m,n) = 29
 */
using System.Threading;
delegate void Akkerman();
internal class Program
{
    private static void Main(string[] args)
    {
        // Задача 64, но в прямом направлении!
        int N = 5;
        int n = 1;
        void Out(int n, int N)
        {
            if (n > N) return;
            {
                Console.Write($"{n} ");
            }
            Out(n + 1, N);
        }

        Out(n, N);
        Console.WriteLine();
        Console.WriteLine();

        // Задача 66
        int Sum(int m, int n)
        {
            if (n == m - 1) return 0;
            return n + Sum(m, n - 1);
        }

        Console.WriteLine(Sum(4, 8));
        Console.WriteLine();

        Console.WriteLine(Sum(1, 15));
        Console.WriteLine();

        //Задача 68
        /*
        Проблема Stack overflow решается созданием нового потока с указанием размера стека:
        Thread(ThreadStart, Int32): в дополнение к делегату ThreadStart принимает числовое значение, 
        которое устанавливает размер стека, выделяемого под данный поток. Делегаты - объекты, которые указывают на методы, т.е.
        что-то типа указателей (*pointer) в Си. Вместо делегата ThreadStart вставляется лямбда-выражение, т.е. 
        безымянная функция вида: (список_параметров) => выражение. С точки зрения типа данных лямбда-выражение 
        представляет делегат. Это самое лямбда - выражение внутри содержит рекурсивно вычисляемую функцию Аккермана вместе с выводом 
        результатов на консоль. 
        N.B. я имею понятие что делаю (использовал google и metanit).
         */
        new Thread(() =>
        {
            uint Akk(uint n, uint m)
            {
                if (n == 0)
                    return m + 1;
                else
                  if ((n != 0) && (m == 0))
                    return Akk(n - 1, 1);
                else
                    return Akk(n - 1, Akk(n, m - 1));
            }

            Console.WriteLine(Akk(3, 2));
            Console.WriteLine();
            Console.WriteLine(Akk(2, 3));
            Console.WriteLine();
            Console.WriteLine(Akk(4, 3));//Переполнение стека, даже если его увеличить до 10Мб!
        }, 2097152 * 5).Start();//Размер стека 10Мб
    }
}