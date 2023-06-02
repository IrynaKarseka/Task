// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1  4  7  2
// 5  9  2  3
// 8  4  2  4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

void PrintArray(double[] array, string sep)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]}{sep}");
    }
}

void PrintMatrix(int[,] matrix, string sep)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j]}{sep}");
        }
        Console.WriteLine();
    }
}

double[] averageColumn(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[j] = array[j] + matrix[i, j];
        }
    }
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        array[i] = array[i] / matrix.GetLength(1);
    }
    return array;
}

// Размер 2d массива.
int rows = 5;
int columns = 5;

// Диапазон чисел.
int min = 2;
int max = 3;

// Cоздаем 2d-массив и заполняем случайными числами согласно размера и диапазона
int[,] array2d = CreateMatrixRndInt(rows, columns, min, max);
Console.WriteLine();

PrintMatrix(array2d, " ");
Console.WriteLine();

double[] array = averageColumn(array2d);

PrintArray(array, ", ");