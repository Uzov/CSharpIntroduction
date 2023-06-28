/*
 Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 */

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введите целое положительное число:");
            string? number = Console.ReadLine()!;
            Console.WriteLine("Какой по счёту ищем элемент?");
            string? position = Console.ReadLine()!;
            //string input = Console.ReadLine();
            //string[] result = input.Split();
            if (Int64.TryParse(number, out var numInt) && Int64.TryParse(position, out var posInt))
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Некорректный ввод!");
            }
            Console.WriteLine("Нажмите любую клавишу или введите 'q' и нажмите Enter для выхода.");
            if (Console.ReadLine() == "q") break;
        }
    }
}