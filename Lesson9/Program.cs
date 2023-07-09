/*
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

        Console.WriteLine(Sum(4,8));
        Console.WriteLine();

        Console.WriteLine(Sum(1, 15));
        Console.WriteLine();
        Console.WriteLine();

        //Задача 68
        int Akkerman(int n, int m)
        {
            return 0;
        }

        Console.WriteLine(Akkerman(3, 2));
        Console.WriteLine();
        Console.WriteLine(Akkerman(2, 3));
    }
}