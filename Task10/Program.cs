//  Напишите программу, которая принимает на
//  вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    int secondDigit = SecondDigit(number);
    Console.WriteLine($"Вторая цифра числа {number} => {secondDigit}");
}
else Console.WriteLine("Некорректный ввод");

int SecondDigit(int num)
{
    return (num % 100 - num % 10) / 10;
}