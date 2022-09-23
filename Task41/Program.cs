// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите количество чисел: ");
int countDigit = Convert.ToInt32(Console.ReadLine());
int[] CreateArray(int sizeArray)
{
    int[] array = new int[sizeArray];
    int i = 0;
    while (i < sizeArray)
    {
        Console.Write($"Введите число №{i + 1}: ");
        int digit = Convert.ToInt32(Console.ReadLine());
        array[i] = digit;
        i += 1;
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("Введённые числа: ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}");
    }
}
int SearchDigit(int[] arr)
{
    int count = 0;
    int numm = 0;
    while (numm < arr.Length)
    {
        if (arr[numm] > 0) count += 1;
        numm += 1;
    }
    return count;
}

int[] arr = CreateArray(countDigit);
PrintArray(arr);
int result = SearchDigit(arr);
Console.WriteLine($"Чисел больше нуля: {result}");