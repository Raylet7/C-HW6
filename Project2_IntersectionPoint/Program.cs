// Программа, определяющая точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2 
// (значения b1, k1, b2 и k2 задаются пользователем).
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double GetX(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}
double GetY(double k2, double b2, double x)
{
    double y = k2 * x + b2;
    return y;
}
void GetIntersectionPoint(double k1, double b1, double k2, double b2)
{
    if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны.");
    }
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Прямые совпадают.");
    }
    else
    {
        Console.Write("Координаты точки пересечения двух прямых: ");
        Console.WriteLine($"({Math.Round(GetX(k1, b1, k2, b2), 2)}; {Math.Round(GetY(k2, b2, GetX(k1, b1, k2, b2)), 2)})");
    }
}
Console.WriteLine();
Console.WriteLine("Программа определения точки пересечения двух прямых.");
Console.WriteLine("Прямые задаются уравнениями y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("(значения b1, k1, b2 и k2 задаются пользователем).");
Console.WriteLine();
Console.WriteLine("Задайте параметры уравнения первой прямой.");
Console.Write("Введите значение b1: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение k1: ");
int k1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте параметры уравнения второй прямой.");
Console.Write("Введите значение b2: ");
int b2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение k2: ");
int k2 = int.Parse(Console.ReadLine()!);
GetIntersectionPoint(k1, b1, k2, b2);
Console.WriteLine();