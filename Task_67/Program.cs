// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();
Console.Write("Задайте число: ");
int n = Convert.ToInt32(Console.ReadLine());

int sum = NaturalNamber(n, 0);
System.Console.WriteLine(sum);

int sum2 = NaturalNamberVar2(n);
System.Console.WriteLine(sum2);

int NaturalNamber(int n, int sum)
{
    sum += n % 10;
    if (n / 10 == 0) return sum;
    else return NaturalNamber(n / 10, sum);

}

int NaturalNamberVar2(int n)
{
    if (n > 0) return n % 10 + NaturalNamberVar2(n / 10);
    return 0;
}


