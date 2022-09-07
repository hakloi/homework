/* Задача 60. ...Сформируйте трёхмерный массив из
неповторяющихся двузначных чисел. Напишите программу,
которая будет построчно выводить массив, добавляя индексы
каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

Console.Clear();

Console.Write("Задайте количество строк: ");
bool isNumberM = int.TryParse(Console.ReadLine(), out int m);

Console.Write("Задайте количество столбцов: ");
bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

Console.Write("Задайте количество слоев: ");
bool isNumberK = int.TryParse(Console.ReadLine(), out int k);

if (isNumberM == false || isNumberN == false || isNumberK == false)
{
    Console.WriteLine();
    Console.WriteLine("Вы ввели данные неправильно!");
    Console.Write("Попробуйте снова!");
}

int[,,] FillArray3D(int m, int n, int k)
{
    int[,,] array = new int[m, n, k];
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                array[i, j, l] = random.Next(10, 100);
            }
        }
    }
    return array;
}

int[,,] result = FillArray3D(m, n, k);

void PrintArray3D(int[,,] arr)
{
    Console.WriteLine();
    Console.WriteLine("Массив: ");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int l = 0; l < arr.GetLength(2); l++)
            {
                Console.Write($"{arr[i, j, l]}({i},{j},{l}) ");
            }
        }
        Console.WriteLine();
    }
}

PrintArray3D(result);