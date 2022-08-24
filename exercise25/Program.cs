/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень, в которую необходимо возвести число: ");
int power = Convert.ToInt32(Console.ReadLine());

int ToThePowerOf(int num, int pow)
{
    int result = 1;
    for (int i = 1; i <= pow; i++)
    {
        result = result * num;
    }
    return result;
}

int res = ToThePowerOf(number, power);
Console.WriteLine($"При возведении числа {number} в {power} степень, получим: {res}.");