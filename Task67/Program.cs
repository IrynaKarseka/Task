// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int sumDigitsInNumberRec = SumDigitsInNumberRec(number);
Console.WriteLine($"Cумма цифр в числе {number} равна {sumDigitsInNumberRec}");

int SumDigitsInNumberRec(int n)
{
    if (n == 0) return 0;
    return n % 10 + SumDigitsInNumberRec(n / 10);
}
