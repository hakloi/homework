/* Задача 50. Напишите программу, которая
на вход принимает число и ищет в двумерном массиве,
и возвращает индексы этого элемента или же
указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
7 -> 0 , 2
5 -> 1 , 0
18 -> нет такого элемента
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
    int[,] arr = new int[m,n];
    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i,j] = random.Next(1,10);
        }
    }
    return arr;
}

int[,] result = FillArray2D(m, n);

void PrintArray2D(int[,] arr)
{
    Console.WriteLine();
    Console.Write("Новый массив:");
    Console.WriteLine();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

FindNumber(result);
PrintArray2D(result);

void FindNumber(int[,] arr)
{
    Console.Write("Введите число, которое хотите найти в массиве: ");
    int num = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (arr[i,j] == num)
            {
                Console.WriteLine();
                Console.WriteLine($"Число {num} - найдено в массиве под индексом -> {i} , {j}!");
            }
        }
    }
}