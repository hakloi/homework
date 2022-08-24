/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int GetSum (int num)
{
    int result = 0;
    while (num > 0)
    {
        int divided = num % 10;
        num = num / 10;
        result = result + divided;
    }
    return result;
}

int res = GetSum(number);
Console.WriteLine($"{number} -> {res}.");