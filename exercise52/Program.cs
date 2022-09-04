/* Задача 52. Задайте двумерный массив
из целых чисел. Найдите среднее арифметическое
элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца:
4,6; 5,6; 3,6; 3.
*/

Console.Clear();

Console.Write("Введите число строк: ");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

Console.Write("Введите число столбцов: ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

if (isNumberM == false || isNumberN == false)
{
    Console.WriteLine("Введены неправильные данные.");
    Console.Write("Введите число!");
    return;
}

int[,] FillArray2D(int m, int n)
{
    int[,] arr = new int[m, n];
    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = random.Next(1, 10);
        }
    }
    return arr;
}

int[,] result = FillArray2D(m, n);

void PrintArray2D(int[,] arr)
{
    Console.WriteLine();
    Console.Write("Массив:");
    Console.WriteLine();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

PrintArray2D(result);

for (int j = 0; j < result.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        sum = sum + result[i, j];
    }
    Console.WriteLine();
    Console.Write($"Среднее арифметическое: {sum / result.GetLength(0)} ");
}