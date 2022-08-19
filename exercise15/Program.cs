/* 
Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.
*/


Console.Clear();
void DayOfWeek() 
{
    Console.WriteLine("Обозначьте цифрой день недели, в которой хотите приступить к работе: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num == 6 | num == 7 ) 
    {
        Console.WriteLine($"Подождите, вы выбрали {num}? Это ведь выходной день!");
    }
    else if (num < 1 | num > 8)
    {
        Console.WriteLine($"Простите? {num} - такого дня недели не существует.");
    }
    else 
    {
        Console.WriteLine($"Отлично! Мы будем ждать вас в этот день недели - {num}.");
    }
}

DayOfWeek();
DayOfWeek();

