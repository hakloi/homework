/*
Задача 21:
Напишите программу, которая принимает на вход координаты
двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();

Console.Write("Введите координату x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты z1: ");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты z2: ");
double z2 = Convert.ToInt32(Console.ReadLine());

double differenceX = x1;
double differenceY = y1;
double differenceZ = z1;

if (x1 > x2)
    {
        differenceX = x1 - x2;
    }
else if (x1 == x2)
    {
        differenceX = x1;
    }
else 
    {
        differenceX = x2 - x1;
    }

if (y1 > y2)
    {
        differenceY = y1 - y2;
    }
else if (y1 == y2)
    {
        differenceY = y1;
    }
else 
    {
        differenceY = y2 - y1;
    }

if (z1 > z2)
    {
        differenceZ = z1 - z2;
    }
else if (z1 == z2)
    {
        differenceZ = z1;
    }
else 
    {
        differenceZ = z2 - z1;
    }


differenceX = Math.Pow(differenceX, 2);
differenceY = Math.Pow(differenceY, 2);
differenceZ = Math.Pow(differenceZ, 2);
double result = Math.Sqrt(differenceX + differenceY + differenceZ);

Console.WriteLine($"Расстояние между точками = {result}.");