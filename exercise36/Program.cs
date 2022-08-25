/* Задача 36: Задайте одномерный массив,
заполненный случайными числами. Найдите
сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Console.Clear();
int[] array = new int[8];

int[] RandomArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-1, 11);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    string text = "\nМассив: ";
    Console.Write(text);
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] resultArray = RandomArray(array);
PrintArray(resultArray);

int SumOfOddElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + arr[i];
        }
    }
    return sum;
}

int res = SumOfOddElements(resultArray);
string space = "\n";
Console.Write(space + $"Сумма элементов, стоящих на нечетных позициях, равна: {res}.");