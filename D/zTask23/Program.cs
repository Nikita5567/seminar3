﻿ 
// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9. 
// 5 -> 1, 8, 27, 64, 125
// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125
//Math.Pow(x, 3)- квадрат
Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= number; i++)
{
    Console.WriteLine(Math.Pow (i, 3));
}


