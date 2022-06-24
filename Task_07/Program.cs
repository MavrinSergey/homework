//Задача 7: Напишите программу, которая принимает на вход
//трёхзначное число и на выходе показывает последнюю цифру
//этого числа.
//456 -> 6
//782 -> 2
//918 -> 8

Console.WriteLine("Программа выдает все четные числа от 1 до числа введенного пользователем.");
Console.Write("Введите число больше 1 ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;
//while (num <= 1) {
//    Console.Write("Введеное число меньше 1, введите число больше 1 ");
//    num = Convert.ToInt32(Console.ReadLine());
//}
while (count <= num) {
    Console.Write($"{count}, ");
    count += 2;
}