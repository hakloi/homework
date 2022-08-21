Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= number)
{
    Console.WriteLine(Math.Pow(i, 3));
    i++;
}