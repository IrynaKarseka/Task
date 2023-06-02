// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

//  m = 3, n = 4.

//  0,5   7,0    -2,0   -0,2
//  1,0  -3,3     8,0   -9,9
//  8,0   7,8    -7,1    9,0

double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double num = rnd.NextDouble() * (max - min) + min;
            matrix[i, j] = Math.Round(num, 1);

        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],7 :F1}");
        }
        Console.WriteLine();
    }
}

int m = 3; // rows
int n = 4; // columns

double[,] array2d = CreateMatrixRndDouble(m, n, -10, 10);
PrintMatrix(array2d);
