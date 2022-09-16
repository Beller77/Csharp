//  Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
 
// Например:
// 452 -> 11
// 82 -> 10
// 9012 -> 12
 
Console.Clear();
 
int Sum_n(int n)
{
    int s = 0;
    while(n > 0)
    {
       s = s + n % 10;
       n = n / 10;
    }
    return s;
}
 
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum_num = Sum_n(num);
Console.Write(sum_num);