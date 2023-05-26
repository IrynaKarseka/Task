// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите первую сторону треугольника А = ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую сторону треугольника B = ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью сторону треугольника C = ");
int number3 = Convert.ToInt32(Console.ReadLine());

bool existTriangle = IsExistTriangle(number1, number2, number3);
Console.WriteLine(existTriangle ? "Существует" : "Не существует ");

bool IsExistTriangle (int a, int b, int c)
{
    if (a + b > c && a + c > b && b + c > a) return true;
    else return false;
}