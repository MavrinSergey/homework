//Задача 19 Напишите программу, которая принимает на вход пятизначное число
//и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

//Console.WriteLine("Программа показывает является ли введенное число полиндромом.");
//Console.Write("Введите пятизначное число ");
//int num = Convert.ToInt32(Console.ReadLine());
//bool Palindrome(int n)
//{
//    while (n < 10000 || n > 99999)
//    {
//        Console.Write("Введено не пятизначное число. Попробуйте еще раз ");
//        n = Convert.ToInt32(Console.ReadLine());
//    }                           
//    if (n / 10000 == n % 10 && n / 1000 % 10 == num % 100 / 10)
//    {
//        return true;
//    }
//    else return false;
//}
//if (Palindrome(num) == true)
//{
//    Console.WriteLine($"Введенной число {num} полиндром");
//}
//else Console.WriteLine($"Введенной число {num} не полиндром");
Console.WriteLine("Эта программа которая принимает на вход число и проверяет, является ли оно палиндромом.");
Console.Write("Введите число ");

ulong number = Convert.ToInt32(Console.ReadLine());
ulong temp = number;
ulong rev = 0;
while (number > 0)
    {
    ulong digital = number % 10;
    rev = rev * 10 + digital;
    number = number / 10;
    Console.WriteLine(digital);
    Console.WriteLine(rev);
    Console.WriteLine(number);
    Console.WriteLine(temp);
    }

if(temp == rev)
    {
    Console.WriteLine( "полидром");
    }

else
    {
    Console.WriteLine("не полидром");
    }