/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
 */
float result = (float)Math.Sqrt(Math.Pow(3 - 2, 2) + Math.Pow(6 - 1, 2) + Math.Pow(8 - (-7), 2));
Console.WriteLine(Math.Round(result, 2));
float result1 = (float)Math.Sqrt(Math.Pow(7 - 1, 2) + Math.Pow((-5) - (-1), 2) + Math.Pow(0 - 9, 2));
Console.WriteLine(Math.Round(result1, 2));