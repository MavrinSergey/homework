//Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Программа возводит число в степень.");
Console.Write("Введите число которое будем возводить в степень: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степнь числа в которую будем возводить: ");
int count = Convert.ToInt32(Console.ReadLine());
int answer = num;

for (int i = 2; i < count; i++)
{
    answer  = answer * num;
}

Console.Write(num);