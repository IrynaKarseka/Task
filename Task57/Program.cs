//  Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.


int[,] array2d = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(array2d);
Console.WriteLine();
int[] array = MatrixToArray(array2d);
Array.Sort(array);
PrintArray(array);
Console.WriteLine();
Dictionary(array);



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
        //Console.Write(i + "|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write($"{matrix[i, j],5} ");

        }

        Console.WriteLine();
    }
}

void PrintArray(int[] arr, string sep = ",")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]} ");
    }
}

int[] MatrixToArray(int[,] matrix)
{

    int[] arr = new int[matrix.Length];
    int k = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[k] = matrix[i, j];
            k++;
        }
    }
    return arr;

}

void Dictionary(int[] arr)
{
    int currentValue = arr[0];
    int count = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == currentValue) count++;
        else
        {
            Console.WriteLine($"{currentValue} встречается {count} раз");
            count = 1;
            currentValue = arr[i];
        }

    }
    Console.WriteLine($"{currentValue} встречается {count} раз");

}