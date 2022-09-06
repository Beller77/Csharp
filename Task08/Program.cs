// Напишите программу, которая на вход
// 1. принимает число N
// 2. выдаёт все четные числа от 1 до N
// 3. вывод результата
 
// Например:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
 
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0) 
    {
        Console.Write(i + " ");
    }
}