/*
 *Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B. НЕ ИСПОЛЬЗОВАТЬ MATH.POW()
3, 5 -> 243 (3⁵)
2, 4 -> 16

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
*/


namespace Lesson3
{
    public class MyMath
    {
        public static int Pow (int num, int pow)
        {
            var result = 1;
            for (int i = 0; i < pow; i++) result *= num;
            return result;
        }
    }
    
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(MyMath.Pow(3, 5));
            Console.WriteLine(MyMath.Pow(2, 4));
        }
    }
}