/* 
Задача 10: Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.
*/

Console.Clear();
void GetRandomNumberSecond()
{
    int randomValue = new Random().Next(100, 999);
    Console.WriteLine($"Рандомное число: {randomValue}!");

    int thirdNumber = randomValue % 10;
    int secondNumber = randomValue % 100 / 10;
    int firstNumber = randomValue / 100;

    Console.WriteLine($"Из числа {randomValue} мы выбираем вторую цифру - {secondNumber}!");
}
GetRandomNumberSecond();
GetRandomNumberSecond();