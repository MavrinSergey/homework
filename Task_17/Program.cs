//Напишите программу которая принимает на вход координаты точки(x и y), причем x!=0 y!=0
//и выдает номер четверти плоскости в которой находится эта точка

Console.WriteLine("Введите координаты точки(X и Y)");
Console.Write("x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y = Convert.ToInt32(Console.ReadLine());

//if (x > 0 && y > 0) Console.WriteLine("Первая четверть");
//else if (x < 0 && y > 0) Console.WriteLine("Вторая четверть");
//else if (x < 0 && y < 0) Console.WriteLine("Третья четверть");
//else if (x > 0 && y < 0) Console.WriteLine("Четвертая четверть");
//else Console.WriteLine("Введены некоректные координаты");
////вариант с функцией
//string Quarter(int x, int y)
//{
//    string result = "";
//    if (x > 0 && y > 0) result = "Первая четверть";
//    else if (x < 0 && y > 0) result = "Вторая четверть";
//    else if (x < 0 && y < 0) result = "Третья четверть";
//    else if (x > 0 && y < 0) result = "Четвертая четверть";
//    else result = "Введены некоректные координаты";
//    return result;
//}
//
//// второй вариант с функцией(упрощенная)
string Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Первая четверть";
    else if (xc < 0 && yc > 0) return "Вторая четверть";
    else if (xc < 0 && yc < 0) return "Третья четверть";
    else if (xc > 0 && yc < 0) return "Четвертая четверть";
    else return "Введены некоректные координаты";
}

string result = Quarter(x, y);
Console.WriteLine(result);