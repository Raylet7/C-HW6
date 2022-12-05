// Программа, позволяющая сгенерировать массив целых чисел размерностью m*n 
// (размерность вводится с клавиатуры) 
// и выводящая его на экран в виде таблицы.
// Программа определяет и выводит на экран минимальное число и его индекс, 
// максимальное число и его индекс и среднее арифметическое. 
void FillArray(int[,] matrix)
{
    Console.Write("Введите начальное значение диапазона элементов массива: ");
    int startElementValue = int.Parse(Console.ReadLine()!);
    Console.Write("Введите конечное значение диапазона элементов массива: ");
    int endElementValue = int.Parse(Console.ReadLine()!);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(startElementValue, endElementValue + 1);
        }
    }
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int GetMinimumValue(int[,] matrix)
{
    int i = 0;
    int j = 0;
    int minimumValue = matrix[i, j];
    for (i = 0; i < matrix.GetLength(0); i++)
    {
        for (j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minimumValue) minimumValue = matrix[i, j];
        }
    }
    return minimumValue;
}
int CountMinimumValueDoubles(int[,] matrix)
{
    int count = 0;
    int minimumValue = GetMinimumValue(matrix);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == minimumValue)
            {
                count++;
            }
        }
    }
    return count;
}
int[,] MinimumValueDoubles(int[,] matrix)
{
    int minimumValue = GetMinimumValue(matrix);
    int[,] minimumValuePositions = new int[CountMinimumValueDoubles(matrix), 2];
    int positionM = 0;
    int positionN = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == minimumValue)
            {
                minimumValuePositions[positionM, positionN] = i;
                positionN++;
                minimumValuePositions[positionM, positionN] = j;
                positionM++;
                positionN = positionN - 1;
            }
        }
    }
    return minimumValuePositions;
}
int GetMaximumValue(int[,] matrix)
{
    int i = 0;
    int j = 0;
    int maximumValue = matrix[i, j];
    for (i = 0; i < matrix.GetLength(0); i++)
    {
        for (j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > maximumValue) maximumValue = matrix[i, j];
        }
    }
    return maximumValue;
}
int CountMaximumValueDoubles(int[,] matrix)
{
    int count = 0;
    int maximumValue = GetMaximumValue(matrix);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == maximumValue)
            {
                count++;
            }
        }
    }
    return count;
}
int[,] MaximumValueDoubles(int[,] matrix)
{
    int maximumValue = GetMaximumValue(matrix);
    int[,] maximumValuePositions = new int[CountMaximumValueDoubles(matrix), 2];
    int positionM = 0;
    int positionN = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == maximumValue)
            {
                maximumValuePositions[positionM, positionN] = i;
                positionN++;
                maximumValuePositions[positionM, positionN] = j;
                positionM++;
                positionN = positionN - 1;
            }
        }
    }
    return maximumValuePositions;
}
void PrintIndexes(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j]);
            if (j != matrix.GetLength(1) - 1) Console.Write(",");
        }
        Console.WriteLine();
    }
}
double GetAverageValue(int[,] matrix)
{
    double sum = 0;
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
            count++;
        }
    }
    double averageValue = sum / count;
    return averageValue;
}
Console.WriteLine();
Console.WriteLine("Программа создания массива целых чисел размерностью m*n");
Console.WriteLine("(размерность вводится с клавиатуры).");
Console.WriteLine("Программа определяет минимальное число и его индекс, ");
Console.WriteLine("максимальное число и его индекс и среднее арифметическое.");
Console.WriteLine();
Console.Write("Введите значение размерности m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение размерности n: ");
int n = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[m, n];
FillArray(matrix);
Console.WriteLine();
Console.WriteLine("Массив:");
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine($"Минимальное число массива: {GetMinimumValue(matrix)}");
Console.WriteLine("Индекс минимального числа:");
int[,] minimumValueIndex = MinimumValueDoubles(matrix);
PrintIndexes(minimumValueIndex);
Console.WriteLine($"Максимальное число массива: {GetMaximumValue(matrix)}");
Console.WriteLine("Индекс максимального числа:");
int[,] maximumValueIndex = MaximumValueDoubles(matrix);
PrintIndexes(maximumValueIndex);
Console.WriteLine($"Среднее арифметическое число массива: {Math.Round(GetAverageValue(matrix), 2)}");
Console.WriteLine();