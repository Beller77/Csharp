//  Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
 
// Например:
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
 
Console.Clear();
 
double[] DoubleArrayRandomizer(int size, int minValue, int maxValue)
{
    Random randomValue = new Random();
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randomValue.NextDouble() * (maxValue - minValue) + minValue;
        array[i] = Math.Round(array[i], 2);
    }
    return array;
}
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}] ");
    }
}
double ArrayMinValueFinder(double[] array)
{
    double minValueFind = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minValueFind) minValueFind = array[i];
    }
    return minValueFind;
}
double ArrayMaxValueFinder(double[] array)
{
    double maxValueFind = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxValueFind) maxValueFind = array[i];
    }
    return maxValueFind;
}
double ValueDifferenceFinder(double minValue, double maxValue)
{
    double valueDifference = maxValue - minValue;
    if (valueDifference < 0) valueDifference = -valueDifference;
    return Math.Round(valueDifference, 2);
}

Console.Clear();
Random randomizer = new Random();
int randomSize = randomizer.Next(2, 16),
    randomMinValue = randomizer.Next(-100, 0),
    randomMaxValue = randomizer.Next(0, 100);

double[] randomArray = DoubleArrayRandomizer(randomSize, randomMinValue, randomMaxValue);
double min_value = ArrayMinValueFinder(randomArray);
double max_value = ArrayMaxValueFinder(randomArray);
double value_difference = ValueDifferenceFinder(min_value, max_value);

PrintArray(randomArray);
Console.WriteLine(value_difference);