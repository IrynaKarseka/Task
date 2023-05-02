// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool fiveDigitNumber = CheckNumberForFiveDigits(number);
bool palynodrome = false;

if (fiveDigitNumber)
{
    palynodrome = Palynodrome(number); // проверить является ли число палиндромом
    if (palynodrome)
    {
        Console.WriteLine($"Да, число {number} является полиндромом");
    }
    else
    {
        Console.WriteLine($"Нет, число {number} не является полиндромом");
    }
}
else
{
    Console.WriteLine($"Некорректное число");
}

bool CheckNumberForFiveDigits(int number)
{
    if (number >= -99999 && number <= -10000 || number >= 10000 && number <= 99999)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool Palynodrome(int number)
{
    int firstDigit = number / 10000;
    int fifthDigit = number % 10;
    int secondDigit = number / 1000 % 10;
    int fourthDigit = number / 10 % 10;

    if (firstDigit == fifthDigit && secondDigit == fourthDigit)
    {
        return true;
    }
    else
    {
        return false;
    }
}
