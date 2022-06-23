// Напишите программу, которая на вход принимает два числа
//и проверяет, является ли первое чилсо квадратом второго

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2 * num2) {
    Console.Write($"Число {num1} является квадратом {num2}");
}
else {
    Console.Write($"Число {num1} не является квадратом {num2}");
}
