// Напишите программу, которая на вход
// 1. принимает 3 числа
// 2. выдаёт максимальное из этих чисел
// 3. вывод результата
 
// Например:
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22
 
Console.Write("Введите первое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье целое число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b & a > c)
{
    Console.WriteLine($"Максимальное число = {a}");
}
else if (b > a & b > c)
{
    Console.WriteLine($"Максимальное число = {b}");
}
else 
{
    Console.WriteLine($"Максимальное число = {c}");
}
