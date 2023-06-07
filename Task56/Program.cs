// Задайте прямоугольный двумерный массив. 
// Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1  4  7  2
// 5  9  2  3
// 8  4  2  4
// 5  2  6  7

// Программа считает сумму элементов в каждой строке и
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],2} ");
        }
        Console.WriteLine();
    }
}

int FindSmallestSum(int[,] matrix)
{
    int line = 0;
    int minNumber = 0;
    int[] array = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[i] = array[i] + matrix[i, j];
        }
    }
    minNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= minNumber)
        {
            if (array[i] != minNumber)
            {
                minNumber = array[i];
                line = i;
            }
            else
            {
                line = -1;
            }
        }
    }
    return line;
}

void PrintResultLine(int result)
{
    if (result < 0)
    {
        Console.WriteLine($" В массиве несколько строк с наименьшей суммой элементов.");
    }
    else
    {
        Console.WriteLine($"{result} - номер строки с наименьшей суммой элементов.");
    }
}

// Размер прямоугольного массива.
int rows = 4;
int columns = 4;//rows;

// Диапазон чисел.
int min = 0;
int max = 1;

// 0Cоздаем прямоугольный двумерный массив и заполняем случайными числами согласно размера и диапазона
int[,] array2d = CreateMatrixRndInt(rows, columns, min, max);
Console.WriteLine();

PrintMatrix(array2d);
Console.WriteLine();

int line = FindSmallestSum(array2d);
PrintResultLine(line);
