// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Clear();
Console.Write("Задайте первое число: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте второе число: ");
int n = int.Parse(Console.ReadLine());
NaturalNamber(m, n);

void NaturalNamber(int m, int n)
{
    if (m > n)
    {
        Console.Write($"{m} ");
        NaturalNamber(m - 1, n);   
    }
    else if (m < n)
    {
        Console.Write($"{m} ");
        NaturalNamber(m + 1, n);
    }
    else
    {
        Console.Write($"{m} ");
    }
}