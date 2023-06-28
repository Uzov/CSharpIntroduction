/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
 */
using System;

namespace Lesson5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Решение Задачи 34
            int[] theArray = new int[] { 345, 897, 568, 234 };
            Counts.MyEven(theArray, out int eresult);
            Console.WriteLine($"Количество чётных чисел в массиве [ {string.Join(", ", theArray)} ]: {eresult}");
            //Решение Задачи 36
            int N = 10; //Число элементов массива
            short[] firstArray = new short[N];
            Random rnd = new ();
            for (int i = 0; i < N; i++) firstArray[i] = Convert.ToInt16(rnd.Next(-32767, 32767));
            Counts.MySum(firstArray, out short fresult);
            Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях [ {string.Join(", ", firstArray)} ]: {fresult}");
            short[] secondArray = new short[] { -4, -6, 89, 6 };//Для проверки
            Counts.MySum(secondArray, out short sresult);
            Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях [ {string.Join(", ", secondArray)} ]: {sresult}");
            //Решение задачи 38:
            float[] thirdArray = new float[] { 3.22F, 4.2F, 1.15F, 77.15F, 65.2F };
            Counts.MyDelta(thirdArray, out float dresult);
            Console.WriteLine($"Разница между максимальным и минимальным элементов массива [ {string.Join(", ", thirdArray)} ]: {dresult}");
        }
    }
    public class Counts
    {
        //static, т.к. метод вызывается через сам класс, а не его экземпляр
        public static void MyEven(int [] numArray, out int result)
        {
            result = 0;
            foreach (int num in numArray)
            {
                if (num % 2 == 0) result++;
            }

        }
        public static void MySum(short[] numArray, out short result)
        {
            result = 0;
            for (int i = 1; i <= numArray.Length; i+=2) result += numArray[i];
        }

        public static void MyDelta(float[] numArray, out float result)
        {
            result = numArray.Max(x => x) - numArray.Min(x => x);
            Console.WriteLine($"{numArray.Max(x => x)} {numArray.Min(x => x)}");
            //Пример для себя (чисто для понимания), разница квадрата максимума и квадрата минимума с применением лямбда - выражения
            //result = numArray.Max(x => x * x) - numArray.Min(x => x * x);            
            Console.WriteLine($"{numArray.Max(x => x * x)} {numArray.Min(x => x * x)}");
        }
    }
}