/* Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Clear();

Console.Write("Задайте количество строк: ");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

Console.Write("Задайте количество столбцов: ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

if (isNumberM == false || isNumberN == false)
{
    Console.WriteLine();
    Console.WriteLine("Вы ввели данные неправильно!");
    Console.Write("Попробуйте снова!");
}

int[,] FillArray2D(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}

int[,] result = FillArray2D(m, n);

void PrintArray2D(int[,] arr)
{
    Console.WriteLine();
    Console.WriteLine("Массив: ");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

PrintArray2D(result);

void MinSumOfRows(int[,] arr)
{
    int minSum = 0;
    int index = 0;
    int sumRow = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        minSum += arr[0, i];
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) sumRow += arr[i, j];
        if (sumRow < minSum)
        {
            minSum = sumRow;
            index = i;
        }
        sumRow = 0;
    }
    Console.WriteLine();
    Console.Write($"Минимальная сумма {minSum} находится на строке {index + 1}.");
}

MinSumOfRows(result);




