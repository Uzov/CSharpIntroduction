/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

internal class Program
{
    private static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= N; i++) if (i % 2 == 0) { Console.WriteLine($"Число {i} чётное."); }
    }
}