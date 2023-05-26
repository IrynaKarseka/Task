// Задайте массив вещественных чисел. 
// Найдите разницу между 
// максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }

    return arr;
}

void PrintArrayDouble(double[] arr, string sep)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

double FindDifferenceMaxMin(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    double diff = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }

    return diff = max - min;
}

int minNum = 0; // минимальное число
int maxNum = 5; // максимальное число
double[] array = CreateArrayRndDouble(5, minNum, maxNum);

Console.Write("[");
PrintArrayDouble(array, ",");
Console.Write("]");
Console.Write(" -> ");

double differenceMaxMin = FindDifferenceMaxMin(array);
Console.WriteLine(Math.Round(differenceMaxMin, 1));
