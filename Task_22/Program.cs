//Задача 22: Напишите программу, которая
//принимает на вход число (N) и выдаёт таблицу
//квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

Console.WriteLine("Программа выдает таблицу квадратов чисел от 1 до числа введенного пользователем.");
Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
int square = 0;
while (count <= num)
{
    square = count *count;
    Console.WriteLine($"{count} -> {square}");   
    count++;
}