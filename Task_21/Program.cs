//Задача 21 Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A ");
Console.Write("x: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B ");
Console.Write("x: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int zB = Convert.ToInt32(Console.ReadLine());

double Distance(int pAx, int pAy, int pAz, int pBx, int pBy, int pBz)
{
    double cat1 = 0;
    double cat2 = 0;
    double cat3 = 0;
    double hypotenuse = 0;
    cat1 = Math.Pow(pAx - pBx,2);
    cat2 = Math.Pow(pAy - pBy,2);
    cat3 = Math.Pow(pAz - pBz,2);
    hypotenuse = Math.Sqrt(cat1 + cat2 + cat3);
    return Math.Round(hypotenuse, 2);
}
double result = Distance(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Растояние между точками А и В: {result}");