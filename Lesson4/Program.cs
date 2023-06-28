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

using System.Collections;

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
        public static int Sum (int num)
        {
            var result = 0;
            while (num > 0)
            {
                result = result + num % 10;
                num = num / 10;
            }
            return result;
        }
        public static IEnumerator GenNumbers(int maxValue)
        {
            Random rnd = new Random();
            int value = rnd.Next();
            for (int i = 0; i < maxValue; i++)
            {
                int result = rnd.Next(1, 100);
                yield return result;
            }
        }
        public static void PrintNumbers(int maxValue)
        {
            GenNumbers(maxValue).Reset();
            do
            {
                var number = (int)GenNumbers(maxValue).Current;
                Console.Write(number);
            }
            while (GenNumbers(maxValue).MoveNext());
        }
    }
      public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(MyMath.Pow(3, 5));
            Console.WriteLine(MyMath.Pow(2, 4));
            Console.WriteLine(MyMath.Sum(452));
            Console.WriteLine(MyMath.Sum(82));
            Console.WriteLine(MyMath.Sum(9012));
            MyMath.PrintNumbers(8);
        }
    }
}