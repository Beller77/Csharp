//  Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
 
// Например:
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
 
Console.Clear();
 
int[] arr = new int[8];
void Arr(int[] arr1)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите число: ");
        int n = Convert.ToInt32(Console.ReadLine());
        arr1[i] = n;
    }
}
void PrintArr(int[] arr1)
{
    Console.Write("[");
    for (int i = 0; i < arr1.Length; i++)
    {
        if (i < arr1.Length-1) Console.Write($" {arr1[i]}, ");
        else Console.Write($" {arr1[i]} ");
    }
    Console.Write("]");
}
Arr(arr);
PrintArr(arr);