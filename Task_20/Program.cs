//Задача 21: Напишите программу, которая
//принимает на вход координаты двух точек и
//находит расстояние между ними в 2D
//пространстве.
//A (3,6); B(2, 1)-> 5,09
//A(7, -5); B(1, -1)-> 7,21

Console.WriteLine("Введите координаты точки A ");
Console.Write("x: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B ");
Console.Write("x: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int yB = Convert.ToInt32(Console.ReadLine());

double Distance(int pAx, int pAy, int pBx, int pBy)
{
    double cat1 = 0;
    double cat2 = 0;
    double hypotenuse = 0;
    cat1 = Math.Pow(pAx - pBx,2);
    cat2 = Math.Pow(pAy - pBy,2);
    hypotenuse = Math.Sqrt(cat1 + cat2);
    return Math.Round(hypotenuse, 2); //округляем 
}
double result = Distance(xA, yA, xB, yB);
Console.WriteLine($"Растояние между точками А и В: {result}");