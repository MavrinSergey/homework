//void PrintArray(int[,] matr)
//{
//
//    for (int i = 0; i < matr.GetLength(0); i++)
//    {
//        for (int j = 0; j < matr.GetLength(1); j++)
//        {
//            System.Console.Write($"{matr[i, j]} ");
//        }
//        System.Console.WriteLine();
//    }
//}
//
//void FillArray (int[,] matr)
//{
//    for (int i = 0; i < matr.GetLength(0); i++)
//    {
//        for (int j = 0; j < matr.GetLength(1); j++)
//        {
//            matr[i,j] = new Random().Next(1, 10);
//        }
//    }
//}
//int[,] matrix = new int[3, 4];
//PrintArray(matrix);
//FillArray(matrix);
//System.Console.WriteLine();
//PrintArray(matrix);
//
//void PrintImage(int[,] image)
//{
//    for (int i = 0; i < image.GetLength(0); i++)
//    {
//        for (int j = 0; j < image.GetLength(1); j++)
//        {
//            //System.Console.Write($"{image[i, j]} ");
//            if (image[i, j] == 0) System.Console.WriteLine(" ");
//            else System.Console.WriteLine("+");
//        }
//        System.Console.WriteLine();
//    }
//}
//int[,] pic = new int[,];
//PrintImage(pic);

//double Factorial (int n)
//{
//    if(n == 1) return 1;
//    else return n * Factorial(n-1);
//}
//for (int i = 1; i < 40; i++)
//{
//    Console.WriteLine($"{i}! = {Factorial(i)}");
//}

//double Fibo(int n)
//{
//    if (n == 1 || n == 2) return 1;
//    else return Fibo(n - 1) + Fibo(n - 2);
//}
//for (int i = 1; i < 45; i++)
//{
//    System.Console.WriteLine($"f({i}) = {Fibo(i)}");
//}

int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber > 7)
{
    dayNumber = dayNumber % 7;
}
switch (dayNumber)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        System.Console.WriteLine("Вторник");
        break;
    case 3:
        System.Console.WriteLine("Среда");
        break;
    case 4:
        System.Console.WriteLine("Четверг");
        break;
    case 5:
        System.Console.WriteLine("Пятница");
        break;
    case 6:
        System.Console.WriteLine("Суббота");
        break;
    case 7:
        System.Console.WriteLine("Воскресенье");
        break;
    case 0:
        System.Console.WriteLine("Воскресенье");
        break;
}








