﻿//Задача 7: Напишите программу, которая принимает на вход
//трёхзначное число и на выходе показывает последнюю цифру
//этого числа.
//456 -> 6
//782 -> 2
//918 -> 8

Console.WriteLine("Программа выдает последнию цифру трехзначного числа введенного пользователем.");
Console.Write("Введите трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());
while (num < 100 || num > 999)
{
    Console.Write("Введено не трехзначное число. Введите трехзначное число ");
    num = Convert.ToInt32(Console.ReadLine());
}
num %= 10;
Console.Write($"Последняя цифра введенного вами числа {num} ");