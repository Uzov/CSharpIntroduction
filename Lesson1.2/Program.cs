/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

using System;

int max = 0;
Console.WriteLine("Нахождение максимального числа. Введите целые положительные числа через пробел:");
string[] numbers = Console.ReadLine().Split(' ');
foreach (string number in numbers) if (Convert.ToInt32(number) > max) max = Convert.ToInt32(number);
Console.WriteLine($"Максимальное число: {max}");