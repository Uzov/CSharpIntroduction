/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int[,] numbers = { { 2, 3, 7 }, { 44, 5, 78 }, { 22, 3, 9 } };
int max = 0;
int rows = numbers.GetUpperBound(0) + 1;    // количество строк
int columns = numbers.Length / rows;        // количество столбцов
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        if (numbers[i,j] > max)
        {
            max = numbers[i,j];
        }
    }
    Console.WriteLine($"Максимальное из трёх чисел: {max}");
    max = 0;
}