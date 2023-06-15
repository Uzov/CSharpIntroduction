/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
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
            if (int.TryParse(number, out var numInt) && int.TryParse(position, out var posInt))
            {
                findPosition(numInt, posInt);
            }
            else
            {
                Console.WriteLine("Некорректный ввод!");
            }
            Console.WriteLine("Нажмите любую клавишу или введите 'q' и нажмите Enter для выхода.");
            if (Console.ReadLine() == "q") break;
        }

        static void findPosition(int num, int pos)
        {
            if (Math.Log10(num) < pos - 1)
            {
                Console.WriteLine($"Нет цифры в позиции {pos}!");
            }
            else
            {
                while (num > 0)
                {
                    if (Math.Log10(num) > pos - 1 && Math.Log10(num) < pos) { Console.WriteLine($"Цифра в позиции {pos} - {num % 10}."); }
                    num /= 10;
                }
            }
        }
    }
}
