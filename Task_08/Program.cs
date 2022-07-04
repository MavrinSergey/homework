//////Задача 8: Напишите программу, которая на вход принимает число (N), 
/////а на выходе показывает все чётные числа от 1 до N.
//////
//////5 -> 2, 4
//////8 -> 2, 4, 6, 8
//Console.WriteLine("Программа выдает все четные числа от 1 до числа введенного пользователем.");
//Console.Write("Введите число больше 1: ");
//int num = Convert.ToInt32(Console.ReadLine());
//int count = 2;
//char simv = ',';
//while (num <= 1) {
//    while (num < 1) {
//        Console.Write("Введеное число меньше 1, введите число больше 1 ");
//        num = Convert.ToInt32(Console.ReadLine());
//    }
//    Console.Write("Введеное число равно 1, введите число больше 1 ");
//    num = Convert.ToInt32(Console.ReadLine());
//}
//
//while (count <= num) { 
//    Console.Write(count);
//    if (count == num) break;
//    else if (count == num-1) break;
//    Console.Write(simv);
//    Console.Write(" ");
//    count += 2;
//}
////Ниже второй вариант решения
Console.WriteLine("Эта программа принимает на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
Console.WriteLine("Введите число и нажмите Enter");
int value = Convert.ToInt32(Console.ReadLine());

if (value <= 1)
{
    Console.WriteLine("Нет таких чисел");
}
else
{
    Console.Write("Результат: 2");
    for (int counter = 4; counter <= value; counter += 2)
        Console.Write($", {counter}");
}