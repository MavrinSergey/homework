// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.Write("Задайте первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = Akk(m, n);
System.Console.WriteLine(result);

int Akk(int m, int n)
{
    if (m == 0) return n + 1;
    else if ((m > 0) && (n == 0)) return Akk(m - 1, 1);
    else return Akk(m-1, Akk(m, n-1));
}