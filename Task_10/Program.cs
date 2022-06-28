//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на 
//выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Программа выдает вторую цифру трехзначного числа введенного пользователем.");
Console.Write("Введите трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());
while (num < 100 || num > 999)
{
    Console.Write("Введено не трехзначное число. Введите трехзначное число ");
    num = Convert.ToInt32(Console.ReadLine());
}
int Second(int n)
{
    int second = n % 100 / 10;
    return second;
}

int sec = Second(num);
Console.WriteLine($"Вторая цифра введенного вами числа {sec}");