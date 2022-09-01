/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Clear();

string space = "\n";
Console.Write(space);
Console.Write("Введите количество: ");
int count = Convert.ToInt32(Console.ReadLine());
int[] array = new int[count];

int[] PrintNumbers(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
    string text = "\nПолученный массив: ";
    Console.Write(text);
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] newArray = PrintNumbers(array);
PrintArray(newArray);

int CountPositiveNumbers(int[] arr)
{
    int countPositive = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            countPositive = countPositive + 1;
        }
    }
    return countPositive;
}

int result = CountPositiveNumbers(array);
Console.Write(space);
Console.Write($"Количество чисел в массиве, которые больше нуля: {result}.");