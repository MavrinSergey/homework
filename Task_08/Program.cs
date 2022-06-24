//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Программа выдает все четные числа от 1 до числа введенного пользователем.");
Console.Write("Введите число больше 1 ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (num <= 1) {
    while (num < 1) {
        Console.Write("Введеное число меньше 1, введите число больше 1 ");
        num = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("Введеное число равно 1, введите число больше 1 ");
    num = Convert.ToInt32(Console.ReadLine());
}

while (count <= num) {
    Console.Write($"{count}, ");
    count += 2;
}