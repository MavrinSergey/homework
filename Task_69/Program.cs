// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();
Console.Write("Задайте первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = Pow(a, b);
System.Console.WriteLine(result);

int Pow(int a, int b)
{
    if (b == 0) return 1;
    else return Pow(a, --b) * a;
}
