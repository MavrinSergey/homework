//Задача 28: Напишите программу, которая
//принимает на вход число N и выдаёт
//произведение чисел от 1 до N.
//4 -> 24
//5 -> 120

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int Sum(int num)
{
    int sum = 1;
    for (int i = 1; i <= a; i++)
    {
        sum = sum * i;
    }
   return sum;
}
int res = Sum(a);
System.Console.WriteLine(res);