/* Задача 47. Задайте двумерный массив
размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
Console.Clear();

Console.Write("Введите количество строк: ");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

Console.Write("Введите количество столбцов: ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

if (isNumberM == false || isNumberN == false)
{
    Console.WriteLine("Введены неправильные данные.");
    Console.Write("Введите число!");
    return;
}

double[,] FillArray2D(int m, int n)
{
    double[,] arr = new double[m,n];
    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i,j] = Convert.ToDouble(random.Next(-10,21));
        }
    }
    return arr;
}

void PrintArray2D(double[,] arr)
{
    Console.WriteLine();
    Console.WriteLine("Новый массив: ");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

double[,] result = FillArray2D(m, n);
PrintArray2D(result);