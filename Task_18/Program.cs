//Задача 18.Напишите программу которая по заданному номеру четверти
//показывает диапазон возможных координат точек в этой четверти (x и y)

Console.WriteLine("Введите порядковый номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());

string Coord(int q)
{
    switch (q)
    {
        case 1:
            return "Диапазон возможных координат x > 0 и y > 0";
        case 2:
            return "Диапазон возможных координат x < 0 и y > 0";
        case 3:
            return "Диапазон возможных координат x < 0 и y < 0";
        case 4:
            return "Диапазон возможных координат x > 0 и y < 0";
        default:
            return "Введена не корректная четверть";
    }
}

string result = Coord(quarter);
Console.WriteLine(result);