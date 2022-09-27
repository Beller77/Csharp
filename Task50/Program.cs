// // Задача 50. Напишите программу,
// // которая на вход принимает позиции элемента в двумерном массиве, 
// // и возвращает значение этого элемента или же указание,
// // что такого элемента нет.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 1, 7 -> такого числа в массиве нет

Console.Clear();
Console.WriteLine();
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           if (matrix[i , j] >= 10)
           {
            Console.Write ($"{matrix[i , j]}   ");
           } 
           else Console.Write ($" {matrix[i , j]}   ");
        }
        Console.WriteLine("]");
    }
}
Console.WriteLine ("Введите строку");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите столбец");
int stlb = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 99);
PrintArray(array2d);
if (str > 3 || stlb > 4)
{
    Console.WriteLine ("Элемента не существует");
}
else Console.WriteLine ($"Значение элемента {array2d[str - 1,stlb - 1]}");