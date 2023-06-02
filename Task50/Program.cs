// Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1  4  7  2
// 5  9  2  3
// 8  4  2  4

// 1, 7 -> такого элемента в массиве нет

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

void PrintMatrix(int[,] matrix, string sep)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}{sep}");
        }
        Console.WriteLine();
    }
}

int DataInput(string message)
{
    int inputValue;

    while (true)
    {
        Console.Write(message);
        inputValue = Convert.ToInt32(Console.ReadLine());
        if (inputValue < 0)
        {
            Console.WriteLine("Число не может быть отрицательным!");
        }
        else
        {
            return inputValue;
        }
    }
}

bool ValidValueArrayElement(int[,] matrix, int x, int y)
{
    if (x < matrix.GetLength(0) && y < matrix.GetLength(1)) return true;
    else return false;
}

int FindValueArrayElement(int[,] matrix, int x, int y)
{
    return matrix[x, y];
}

// Размер 2d массива.
int rows = 3;
int columns = 4;

// Диапазон чисел.
int min = 0;
int max = 9;

// Cоздаем 2d-массив и заполняем случайными числами согласно размера и диапазона
int[,] array2d = CreateMatrixRndInt(rows, columns, min, max);

// Ввод позиции элемента
Console.WriteLine();
string messageRow = "Введите позицию элемента в строке: ";
int rowElementPosition = DataInput(messageRow);

string messageColumn = "Введите позицию элемента в колонке: ";
int columnElementPosition = DataInput(messageColumn);
Console.WriteLine();

PrintMatrix(array2d, "  ");
Console.WriteLine();

// 
bool valid = ValidValueArrayElement(array2d, rowElementPosition, columnElementPosition);

if (valid)
{
    int elementValue = FindValueArrayElement(array2d, rowElementPosition, columnElementPosition);
    Console.Write($"{rowElementPosition}, {columnElementPosition} -> {elementValue}");
}
else
{
    Console.WriteLine($"{rowElementPosition}, {columnElementPosition} -> Такого элемента в массиве нет");
}