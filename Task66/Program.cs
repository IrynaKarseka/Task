// Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите натуральное число M = ");
int numberM = CheckNaturalNum();
Console.Write("Введите натуральное число N = ");
int numberN = CheckNaturalNum();

SumNaturalNumbers(numberM, numberN);
Console.WriteLine($"Сумма натуральных элементов в промежутке от M = {numberM} до N = {numberN} -> {SumNaturalNumbers(numberM, numberN)}");

int CheckNaturalNum()
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

int SumNaturalNumbers(int numM, int numN)
{
    if (numM == numN)
        return numN;
    return numN + SumNaturalNumbers(numM, numN - 1);
}
