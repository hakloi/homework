/* 
Напишите программу, которая выводит третью цифру
заданного числа или сообщает, что третьей цифры нет. 
*/

Console.Clear();
void GetRandomNumberThird()
{
    int randomValue = new Random().Next(10, 999);
    Console.WriteLine($"Рандомное число: {randomValue}!");

    if (randomValue > 10 && randomValue < 100) 
    {
        Console.WriteLine($"Число {randomValue} является двухзначным.");
        Console.WriteLine("Третьей цифры нет.");
    } 
    else 
    {
        int thirdNumber = randomValue % 10;
        Console.WriteLine($"Из числа {randomValue} мы выбираем тратью цифру - {thirdNumber}!");
    }
}
GetRandomNumberThird();
GetRandomNumberThird();