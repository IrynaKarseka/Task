// : Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}
else
{
    int thirdDigit = ThirdDigit(number);
    Console.WriteLine($"{number} -> {thirdDigit}");
}

int ThirdDigit(int num)
{
    while (num > 1000)
    {
        num = num / 10;
    }
    return num % 10;
}