// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 5 && number <= 7)
{
    Console.WriteLine($"Да, {number} является выходным днём");
}
else if(number >= 1 && number <= 5)
{
    Console.WriteLine($"Нет,{number} не является выходным днем");
}
else
{
    Console.WriteLine("Некорректное число");
}