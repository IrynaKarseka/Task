// Задайте массив 
// заполненный случайными 
// положительными трёхзначными числами. 
// Напишите программу, которая покажет
// количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr, string sep)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

int CountEvenNumbersInAnArray(int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0) counter +=1; 
    }
    return counter;
}

int minNum = 100; // минимальное положительное трёхзначное число
int maxNum = 999; // максимальное положительное трёхзначное число
int[] array = CreateArrayRndInt(4, minNum, maxNum);

Console.Write("[");
PrintArray(array, ",");
Console.Write("]");
Console.Write(" -> ");

int quantityEvenNumbers = CountEvenNumbersInAnArray(array);
Console.WriteLine(quantityEvenNumbers);