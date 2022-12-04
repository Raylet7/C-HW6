// Программа, вычисляющая сколько чисел больше 0 ввёл пользователь из М чисел.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223 -> 3
void ReadArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}-е число: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
}
void CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    Console.WriteLine($"Количество положительных чисел равно: {count}");
}
Console.WriteLine();
Console.WriteLine("Программа вычисления количества положительных чисел");
Console.WriteLine("(пользователь вводит М чисел с клавиатуры).");
Console.WriteLine();
Console.Write("Введите количество всех чисел: ");
int numberOfElements = int.Parse(Console.ReadLine()!);
if (numberOfElements < 1)
{
    Console.WriteLine("Неверный ввод");
}
else
{
    int[] array = new int[numberOfElements];
    ReadArray(array);
    CountPositiveNumbers(array);
}
Console.WriteLine();