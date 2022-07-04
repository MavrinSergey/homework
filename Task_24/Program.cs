//Задача 24. Напишите программу, которая принимает на вход число (А)
//и выдает сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int Sum(int num)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum = sum + i;
    }
   return sum;
}
int res = Sum(a);
System.Console.WriteLine(res);