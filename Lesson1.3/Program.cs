﻿/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
 */

int a = 4;
bool c = (a % 2) == 0 ? true : false;
if (c) { Console.WriteLine($"Число чётное."); }