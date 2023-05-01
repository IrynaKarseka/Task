// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,2

System.Console.Write("Введите координату X1: ");
int xA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y1: ");
int yA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату X2: ");
int xB = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y2: ");
int yB = Convert.ToInt32(Console.ReadLine());

double result = Distance(xA, yA, xB, yB);
System.Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToZero));

double Distance(int x1, int y1, int x2, int y2)
{
    double square = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return square;
}

// Console.WriteLine("Введите координаты точки B");
// Console.WriteLine("x = ");
// int xB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("y = ");
// int yB = Convert.ToInt32(Console.ReadLine());

// double distance = Distance (xA, yA, xB, yB);

// Console.WriteLine(Math.Round(distance, 2 , MidpointRounding.ToZero));

// double Distance(int x1, int y1, int x2, int y2 )
// {
//     int katet1 = x1 - x2;
//     int katet2 = y2 - y1;
//     double hypo = Math.Sqrt(katet1 * katet1 + katet2 * katet2);
//     return hypo; 
// }