//Напишите программу которая принимает на вход координаты точки(x и y), причем x!=0 y!=0
//и выдает номер четверти плоскости в которой находится эта точка

//Console.WriteLine("Введите координаты точки(X и Y)");
//Console.Write("x: ");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.Write("y: ");
//int y = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки(X и Y) через пробел ");
int[] xy = Console.ReadLine().Split().Select(int.Parse).ToArray();//Ввод данных через пробел

string Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Первая четверть";
    else if (xc < 0 && yc > 0) return "Вторая четверть";
    else if (xc < 0 && yc < 0) return "Третья четверть";
    else if (xc > 0 && yc < 0) return "Четвертая четверть";
    else return "Введены некоректные координаты";
}

string result = Quarter(xy[0], xy[1]);
Console.WriteLine(result);