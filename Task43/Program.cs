// Напишите программу, 
// которая найдёт, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите b1 = ");
double b1 = DateInput();
Console.Write("Введите k1 = ");
double k1 = DateInput();
Console.Write("Введите b2 = ");
double b2 = DateInput();
Console.Write("Введите k2 = ");
double k2 = DateInput();

double x = FindXCoordinate(b1, b2, k1, k2);
double y = FindYCoordinate(b1, k1, x);
PrintResult(b1, k1, b2, k2, x, y);

double DateInput()
{
    return Convert.ToDouble(Console.ReadLine());
}

double FindXCoordinate(double b1, double b2, double k1, double k2)
{
    double X = (b1 - b2) / (k2 - k1); ;
    return X;
}

double FindYCoordinate(double b1, double k1, double x)
{
    double Y = k1 * x + b1;
    return Y;
}

void PrintResult(double b1, double b2, double k1, double k2, double x, double y)
{
    Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");
}

