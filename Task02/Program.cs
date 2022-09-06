// // Напишите программу, которая на вход
// 1. принимает 2 числа
// 2. выдаёт, какое число большее, а какое меньшее
// 3. вывод результата
 
// Например:
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
 
Console.Write("Введите первое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"Большее число = {a}");
    Console.WriteLine($"Меньшее число = {b}");
}
else
{
    Console.WriteLine($"Большее число = {b}");
    Console.WriteLine($"Меньшее число = {a}");
}