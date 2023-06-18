/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int number1 = 14212;
Palindrom(number1);

int number2 = 12821;
Palindrom(number2);

int number3 = 23432;
Palindrom(number3);

void Palindrom(int num)
{
    if ((num % 10 == num / 10000) && ((num % 100 / 10 == num / 1000 % 10))) Console.WriteLine($"Число {num} - палиндром.");
        else Console.WriteLine($"Число {num} - не палиндром.");
}