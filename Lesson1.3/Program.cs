﻿/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
 */


int [] numbers = { 4, -3, 7 };
foreach (var number in numbers)
{
    if ((number % 2) == 0) { Console.WriteLine($"Число {number} чётное."); } else { Console.WriteLine($"Число {number} нечётное."); }
}