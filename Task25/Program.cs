// Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int degreeNumber = 0;
if (numberB > 0)
{
    degreeNumber = DegreeNumbers(numberA, numberB);
    Console.WriteLine(degreeNumber);
}
else
{
    Console.WriteLine("error");
}

int DegreeNumbers(int a, int b)
{
    int result = 1;
    int count = 0;
    while (count < b)
    {
        result = result * a;
        count++;
    }
    return result;
}
