// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Clear();
Console.Write("Задайте первое числочисло: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте второе число: ");
int n = int.Parse(Console.ReadLine());

NaturalNamber(m,n);

void NaturalNamber(int m, int n)
{
    Console.Write($"{m}, ");
    if (m > n)
    {
        NaturalNamber(m - 1, n);   
    }
    else if (m < n)
    {
        NaturalNamber(m + 1, n);
    }
    else{}
}