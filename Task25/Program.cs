//  Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
 
// Например:
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
 
Console.Clear();
 
int Exp_n1_n2(int n1, int n2)
{
    int n1_n2=1;
    for(int i=0; i<n2; i++)
        {
        n1_n2*=n1;
        }
    return n1_n2;
}
 
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int n = Convert.ToInt32(Console.ReadLine());
int num_n = Exp_n1_n2(num, n);
Console.Write(num_n);