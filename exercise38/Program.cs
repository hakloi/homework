/* Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
Console.Clear();
double[] array = new double[5];

double[] RandomArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    string text = "\nМассив: ";
    Console.Write(text);
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

double[] newArray = RandomArray(array);
PrintArray(newArray);

double DifferenceBetweenMinMax (double[] arr)
{
    string space = "\n";
    double max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    Console.Write(space);
    Console.Write($"Максимальное число массива: {max}");
    Console.Write(space);
    double min = 100;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    Console.Write($"Минимальное число массива: {min}");
    Console.Write(space);

    double diff = max - min;
    return diff;
}

double differenceMaxMin = DifferenceBetweenMinMax(newArray);
Console.Write("Разница между значениями: " + differenceMaxMin);