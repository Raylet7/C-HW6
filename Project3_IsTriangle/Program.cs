// Программа, определяющая, являются ли сторонами треугольника
// введённые три целых положительных числа. 
// Если да, программа выводит площадь, периметр, 
// значения углов треугольника в градусах, 
// является ли он прямоугольным, равнобедренным, равносторонним.
bool IsIncorrectInput(int number)
{
    return number < 1;
}
bool IsTriangle(int a, int b, int c)
{
    return a + b > c && a + c > b && b + c > a;
}
double GetTriangleSquare(int a, int b, int c)
{
    double semiPerimeter = GetTrianglePerimeter(a, b, c) / 2;
    double s = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
    return Math.Round(s, 2);
}
int GetTrianglePerimeter(int a, int b, int c)
{
    int p = a + b + c;
    return p;
}
double[] GetTriangleAngles(int a, int b, int c)
{
    double[] angles = new double[3];
    angles[0] = Math.Acos((double)(a * a + b * b - c * c) / (2 * a * b)) * 180 / Math.PI;
    angles[1] = Math.Acos((double)(b * b + c * c - a * a) / (2 * b * c)) * 180 / Math.PI;
    angles[2] = 180 - angles[0] - angles[1];
    return angles;
}
bool IsRightTriangle(int a, int b, int c)
{
    return a * a == b * b + c * c
    || b * b == a * a + c * c
    || c * c == a * a + b * b;
}
bool IsIsoscelesTriangle(int a, int b, int c)
{
    return a == b || b == c || a == c;
}
bool IsEquilateralTriangle(int a, int b, int c)
{
    return a == b && b == c;
}
Console.WriteLine();
Console.WriteLine("Программа определения возможности существования треугольника");
Console.WriteLine("(значения трех сторон задаются вводом целых положительных чисел).");
Console.WriteLine("Программа выводит площадь, периметр, значения углов треугольника в градусах.");
Console.WriteLine("Программа определяет является ли он прямоугольным, равнобедренным, равносторонним.");
Console.WriteLine();
InputA:
Console.Write("Введите первое целое положительное число: ");
int a = int.Parse(Console.ReadLine()!);
if (IsIncorrectInput(a))
{
    Console.WriteLine("Неверный ввод");
    goto InputA;
}
InputB:
Console.Write("Введите второе целое положительное число: ");
int b = int.Parse(Console.ReadLine()!);
if (IsIncorrectInput(b))
{
    Console.WriteLine("Неверный ввод");
    goto InputB;
}
InputC:
Console.Write("Введите третье целое положительное число: ");
int c = int.Parse(Console.ReadLine()!);
if (IsIncorrectInput(c))
{
    Console.WriteLine("Неверный ввод");
    goto InputC;
}
if (IsTriangle(a, b, c))
{
    Console.WriteLine("Треугольник с заданными сторонами существует.");
    Console.WriteLine($"Площадь треугольника равна: {GetTriangleSquare(a, b, c)}.");
    Console.WriteLine($"Периметр треугольника равен: {GetTrianglePerimeter(a, b, c)}.");
    double[] angles = GetTriangleAngles(a, b, c);
    Console.WriteLine($"Первый угол треугольника равен: {Math.Round(angles[0], 2)} градусов.");
    Console.WriteLine($"Второй угол треугольника равен: {Math.Round(angles[1], 2)} градусов.");
    Console.WriteLine($"Третий угол треугольника равен: {Math.Round(angles[2], 2)} градусов.");
    if (IsRightTriangle(a, b, c))
    {
        Console.WriteLine("Треугольник является прямоугольным.");
    }
    else
    {
        Console.WriteLine("Треугольник не является прямоугольным.");
    }
    if (IsIsoscelesTriangle(a, b, c))
    {
        Console.WriteLine("Треугольник является равнобедренным.");
    }
    else
    {
        Console.WriteLine("Треугольник не является равнобедренным.");
    }
    if (IsEquilateralTriangle(a, b, c))
    {
        Console.WriteLine("Треугольник является равносторонним.");
    }
    else
    {
        Console.WriteLine("Треугольник не является равносторонним.");
    }
}
else
{
    Console.WriteLine("Треугольник с заданными сторонами не существует.");
}