//  Напишите программу, которая задаёт массив из 8 элементов и 
//  выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] arr = new int[8];

FillArray(arr);
PrintArray(arr);

void FillArray(int[] array)
{
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 99);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    int i = 0;
    while (i < array.Length)
    {
        Console.Write($"{array[i]}");
        i++;

        if (i < array.Length)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}
