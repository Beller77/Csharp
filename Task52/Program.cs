// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

double[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
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


void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] >= 10)
            {
                Console.Write($"{matrix[i, j]}   ");
            }
            else Console.Write($" {matrix[i, j]}   ");
        }
        Console.WriteLine("]");
    }
}

void AverageColumns(double[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double temp = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            temp += matrix[i, j];
        }
        temp = Math.Round(temp / matrix.GetLength(0), 2, MidpointRounding.AwayFromZero);
        Console.Write($"{temp}  ");
    }
}

Console.WriteLine("Rоличество строк");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Rоличество столбцов");
int stlb = Convert.ToInt32(Console.ReadLine());
double[,] array2d = CreateMatrixRndInt(str, stlb, 1, 9);
PrintArray(array2d);
AverageColumns(array2d);