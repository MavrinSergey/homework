// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Clear();
Console.Write("Задайте первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = m + 1;
int result = NaturalNamber(m, n, a);
Console.WriteLine(result);

int NaturalNamber(int m, int n, int a)// не работает если m больше n
{
    if (a == n + 1) return m;
    else return NaturalNamber(m + a, n, ++a);
}
