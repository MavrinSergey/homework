//Задача 28: Напишите программу, которая
//принимает на вход число N и выдаёт
//произведение чисел от 1 до N.
//4 -> 24
//5 -> 120

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int res = 1;
int start = 1;
while (start <= n)
{
    try
    {
        checked
        {
            res = res * start;
            start++;
        }
    }
    catch (System.Exception)
    {

        System.Console.WriteLine("Переполнение типа!");
        break;
    }
}
Console.WriteLine($"Произведение чисел от 1 до {start-1} равно {res}");