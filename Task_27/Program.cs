//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int DigitsCount(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num /= 10;
    }
    return sum;
}

int res = DigitsCount(a); //22-26 строка дополнение.
while (res > 9)// при получении двухзначного res мы сново применим к нему функцию, чтобы результат был однозначным
               //Трехзначное число получится не сможет так как не даст int ввести такое число
{
    res = DigitsCount(res);
}
System.Console.WriteLine(res);