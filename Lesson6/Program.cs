/*
 Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 */

namespace Lesson6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                //Решение Задачи 41
                Counts.Zero();
                //Решение Задачи 43
                Counts.Cross();
                Console.WriteLine("Нажмите любую клавишу или введите 'q' и нажмите Enter для выхода.");
                if (Console.ReadLine() == "q") break;
            }
        }
        public class Counts
        {
            public static void Zero()
            {
                var inputList = new List<Int16>();
                bool flag = true;

                Console.WriteLine("Введите целые числа через запятую:");
                string? input = Console.ReadLine()!;
                string[] inputArray = input.Split(",");
                foreach (string number in inputArray)
                {
                    if (Int16.TryParse(number, out var numInt)) inputList.Add(numInt);
                    else
                    {
                        Console.WriteLine($"Некорректный ввод ({number})!");
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    var greaterZero = (inputList.Where(element => element > 0)).Count();
                    Console.WriteLine($"Введено {greaterZero} чисел(числа) больше нуля.");
                }
                flag = true;
            }
            public static void Cross()
            {
                // x=-(b2-b1)/(k2-k1); y= k2 * x + b2 или k1 * x + b1
                Console.WriteLine($"Точка пересечения прямых.");
            }
        }

    }
}