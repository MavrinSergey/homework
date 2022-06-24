//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Программа находит наибольшее число из трех введенных пользоватьелем.");
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) {
    if (num1 > num3) {
        Console.Write($"максимальное число = {num1}");
}
    else {
        Console.Write($"максимальное число = {num3}");
    }
}
else {
    if (num2 > num3) {
        Console.Write($"максимальное число = {num2}");
}
    else {
        Console.Write($"максимальное число = {num3}");
    }

}