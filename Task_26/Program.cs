//Задача 26: Напишите программу, которая принимает
//на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int DigitsCount(int num)
{
int count = 1;
while (num > 9)
{
    num /= 10;
    count++;
}
return count;
}
int res = DigitsCount(a);
System.Console.WriteLine(res);