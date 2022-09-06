/* Задача 54: Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
    int[,] array = new int[m,n];
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(1,10);
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
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

PrintArray2D(result);

int[,] OrderedArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i,k] < arr[i, k+1])
                {
                    int temp = arr[i,k+1];
                    arr[i,k+1] = arr[i,k];
                    arr[i,k] = temp;
                }

            }
        }
    }
    return arr;
}

int[,] res = OrderedArray(result);

Console.WriteLine();
Console.Write("Преобразуем массив, чтобы элементы располагались в строке по мере убывания!");
PrintArray2D(res);