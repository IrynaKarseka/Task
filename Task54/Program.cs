// Задайте двумерный массив.
// Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки
// двумерного массива.

// Например, задан массив:

// 1  4  7  2
// 5  9  2  3
// 8  4  2  4

// В итоге получается вот такой массив:

// 7  4  2  1
// 9  5  3  2
// 8  4  4  2

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
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine();
    }
}

int[,] SortMaxMinElementsString(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

    int number = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0)
            {
                newMatrix[i, j] = matrix[i, j];
            }
            else
            {
                number = matrix[i, j];
                if (number <= newMatrix[i, j - 1])
                {
                    newMatrix[i, j] = matrix[i, j];
                }
                else
                {
                    int count = j;
                    while (newMatrix[i, count - 1] < number)
                    {
                        newMatrix[i, count] = newMatrix[i, count - 1];
                        newMatrix[i, count - 1] = number;
                        count--;
                        if (count == 0) break;
                    }
                }
            }
        }
    }
    return newMatrix;
}

// Размер 2d массива.
int rows = 3;
int columns = 4;

// Диапазон чисел.
int min = 0;
int max = 9;

// Cоздаем 2d-массив и заполняем случайными числами согласно размера и диапазона
int[,] array2d = CreateMatrixRndInt(rows, columns, min, max);
Console.WriteLine();

PrintMatrix(array2d);
Console.WriteLine();

array2d = SortMaxMinElementsString(array2d);
PrintMatrix(array2d);
