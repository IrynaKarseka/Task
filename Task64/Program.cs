//  Задайте значение N. Напишите программу, которая 
//  выведет все натуральные числа в промежутке от N до 1. 
//  Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1


Console.Write("Введите натуральное число = ");
int number = InputNaturalNum();
NaturalNamber(number);

int InputNaturalNum()
{
    int num = 0;
    while (!false)
    {
        num = Convert.ToInt32(Console.ReadLine());
        if (num > 0)
        {
            return num;
        }
         else
        {
            Console.WriteLine("Число должно быть натуральным");
        }
    }
}

void NaturalNamber(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturalNamber(num - 1);
}
