/*
Задача 19:
Напишите программу, которая принимает на вход
пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

Console.Clear();
int num, rem, sum = 0, temp;

Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());
temp = num;
while (Convert.ToBoolean(num))
{
    rem = num % 10;  
    num = num / 10; 
    sum = sum * 10 + rem; 
}
Console.WriteLine("Перевернутое число: {0}", sum);
if (temp == sum) 
{
    Console.WriteLine("Число является палиндромом.");
}
else
{
    Console.WriteLine("Число не явялется палиндромом.");
}