// Напишите программу, которая на вход
// 1. принимает число
// 2. выдаёт, является ли число четным
// 3. вывод результата
 
// Например:
// 4 -> да
// -3 -> нет
// 7 -> нет
 
Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else 
{
    Console.WriteLine("Число нечетное");
}