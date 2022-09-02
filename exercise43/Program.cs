/* Задача 43: Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями
y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Clear();

string space = "\n";
Console.Write("Первое уравнение!" + space);
Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write(space + "Второе уравнение!" + space);
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

double diffK = k1 - k2;
double diffB = b2 - b1;

double x = diffB / diffK;
double y = k1 * x + b1;

Console.Write(space);
Console.Write($"Прямые пересекаются в ({x}; {y})");