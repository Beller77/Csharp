﻿// Напишите программу, которая на вход
// 1. принимает трехзначное число
// 2. показывает вторую цифру этого числа
// 3. вывод результата
 
// Например:
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a % 100 / 10;
Console.WriteLine($"Вторая цифра: {b}");
