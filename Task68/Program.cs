// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// Даны два неотрицательных числа m и n.
int numberM = 3;
int numberN = 2;

int akkermanA = FunctionAkkermanVersion1(numberM, numberN);
Console.WriteLine($"Функция Анккермана = {akkermanA}");

int akkermanB = FunctionAkkermanVersion2(numberM, numberN);
Console.WriteLine($"Функция Анккермана = {akkermanB}");

// Функция Аккермана, псевдокод из Википедии
// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))
int FunctionAkkermanVersion1(int numM, int numN)
{
    if (numM == 0)
    {
        return numN + 1;
    }
    if (numN == 0)
    {
        return FunctionAkkermanVersion1(numM - 1, 1);
    }
    return FunctionAkkermanVersion1(numM - 1, FunctionAkkermanVersion1(numM, numN - 1));
}


// функция ack(n, m)
//    пока n ≠ 0
//      если m = 0
//        m:= 1
//      иначе
//        m:= ack(n, m - 1)
//      n:= n - 1
//    вернуть m + 1
int FunctionAkkermanVersion2(int numM, int numN)
{
    while (numM != 0)
    {
        if (numN == 0)
        {
            numN = 1;
        }
        else
        {
            numN = FunctionAkkermanVersion2(numM, numN - 1);
        }
        numM = numM - 1;
    }
    return numN + 1;
}