// Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2  4 | 3  4
// 3  2 | 3  3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void PrintTwoMatrix(int[,] matrix1, int[,] matrix2)
{
    string charX = " ";
    int lengthMatrix = matrix1.GetLength(0) < matrix2.GetLength(0) ? matrix2.GetLength(0) : matrix1.GetLength(0);
    for (int i = 0; i < lengthMatrix; i++)
    {

        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            if (i < matrix1.GetLength(0))
            {
                Console.Write($"{matrix1[i, j],3}");
            }
            else
            {
                Console.Write($"{charX,3}");
            }
        }
        Console.Write("  |");
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            if (i < matrix2.GetLength(0))
            {
                Console.Write($"{matrix2[i, j],3}");
            }
            else
            {
                Console.Write($"{charX,3}");
            }
        }
        Console.WriteLine();
    }
}

int[,] matrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int sum = 0;
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
    return resultMatrix;
}


// Размер 2-x матриц.
int rows1 = 3;
int columns1 = 4;
int rows2 = columns1; // Матрицу 1 можно умножить на матрицу 2 только, если число столбцов матрицы 1 равняется числу строк матрицы 2.
int columns2 = 3;

// Диапазон чисел.
int min = 2;
int max = 4;

// Cоздаем 2 двумерныx массивa и заполняем случайными числами согласно размера и диапазона
int[,] firstArray2d = CreateMatrixRndInt(rows1, columns1, min, max);
int[,] secondArray2d = CreateMatrixRndInt(rows2, columns2, min, max);
Console.WriteLine();

PrintTwoMatrix(firstArray2d, secondArray2d);
Console.WriteLine();

int[,] resultMatrix = matrixMultiplication(firstArray2d, secondArray2d);
PrintMatrix(resultMatrix);
