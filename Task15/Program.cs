﻿// Напишите программу, которая на вход
// 1. принимает цифру, обозначающую день недели
// 2. проверяет, является ли этот день выходным
// 3. вывод результата
 
// Например:
// 6 -> да
// 7 -> да
// 1 -> нет
 
Console.Clear();
Console.Write("Введите цифру от 1 до 7, обозначающую день недели: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 6)
{
    Console.Write("Этот день не выходной");
}
else
{
    Console.Write("Этот день выходной");
}