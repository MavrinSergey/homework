//Задача 23Напишите программу, которая принимает 
//на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Программа выдает таблицу кубов чисел от 1 до числа введенного пользователем.");
Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
int cub = 0;
if (num < 0)
{
    //count *= -1;//можно добавить тогда таблица будет от -1
    while (count >= num)
    {
        cub = count * count * count;
        Console.WriteLine($"{count,3} -> {cub,5}");
        count--;
    }
}
else while (count <= num)
    {
        cub = count * count * count;
        Console.WriteLine($"{count,3} -> {cub,5}");
        count++;
    }