// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();
Console.Write("Задайте число: ");
int num = int.Parse(Console.ReadLine());
NaturalNamber(num);

void NaturalNamber(int num)
{
    
    if (num==0) return;
    Console.Write($"{num} ");
    NaturalNamber(num-1);
    Console.Write($"{num} ");
    
}