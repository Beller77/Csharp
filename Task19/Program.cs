Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
void Palindrom5(int n1)
{
    while (n1 > -10000 && n1 < 10000 || n1 > 99999 || n1 < -99999)
    {
        Console.Write("Введите пятизначное число: ");
        n1 = Convert.ToInt32(Console.ReadLine());
    }
    int nleft = n1 / 10000;
    int nright = n1 % 10;
    if (nleft == nright)
    {
        nleft = n1 / 1000 % 10;
        nright = n % 100 / 10;
        if (nleft == nright) Console.Write($"Число {n1} палиндром.");
        else Console.Write($"Число {n1} не палиндром.");
    }
    else
        Console.Write($"Число {n1} не палиндром.");
}
Palindrom5(n);