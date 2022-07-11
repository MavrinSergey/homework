//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.WriteLine("Программа находит точку пересечения двух прямых");
System.Console.WriteLine("Введите значение уровнений.");
System.Console.WriteLine("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double y;
double x;

x = (b2 - b1) / (k1-k2);
y = k2 * x + b2;
System.Console.WriteLine(x);
System.Console.WriteLine(y);