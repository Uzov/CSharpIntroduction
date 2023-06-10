/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

int[] numbers = { 2, 3, 7 };
int max = 0;
foreach (int number in numbers)
{
    if (number > max)
    {
        max = number;
    }
}
Console.WriteLine($"Максимальное из трёх чисел: {max}");