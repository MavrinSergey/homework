﻿//Напишите программу которая принимает на вход число (N)
//и выдает таблицу кубов чисел от 1 до N

Console.WriteLine("Программа выдает таблицу кубов чисел от 1 до числа введенного пользователем.");
Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
char simv = ',';
if (num < 0)
{
    count *= -1;
    while (count >= num)
    {
        Console.Write(Math.Pow(count, 3));
        if (count == num) break;
        Console.Write(simv);
        Console.Write(" ");
        count--;
    }
}
else while (count <= num)
    {
        Console.Write(Math.Pow(count, 3));
        if (count == num) break;
        Console.Write(simv);
        Console.Write(" ");
        count++;
    }