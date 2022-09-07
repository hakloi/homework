/* Задача 58: Задайте две матрицы. Напишите программу,
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int[,] firstArray = FillArray2D(m, n);
int[,] secondArray = FillArray2D(m, n);

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

PrintArray2D(firstArray);
PrintArray2D(secondArray);

int[,] ResultMatrix(int[,] arr1, int[,] arr2)
{
    int[,] result = new int[arr1.GetLength(0), arr1.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            result[i,j] = arr1[i,j] * arr2[i,j];
        }
    }
    return result;
}

int[,] res = ResultMatrix(firstArray, secondArray);
PrintArray2D(res);