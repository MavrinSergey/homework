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
    Console.WriteLine($"{count, 3} -> {square, 5}");   
    count++;
}

//через массив
Console.WriteLine ("Программа запрашивает число N и выводит таблицу квадратов чисел");
Console.WriteLine ("Введите число N: ");
int n = Convert.ToInt32 (Console.ReadLine());
int i = 1;
int[] tableq = new int [n];

while (i <= n)
{
tableq[i - 1] = i * i;
i++;
}
Console.WriteLine ($"Таблица квадратов чисел от 1 до {n}: {String.Join(", ",tableq)}");