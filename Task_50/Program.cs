// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет

Console.Clear();
int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) System.Console.Write("[ ");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3}");
            else System.Console.Write($"{array[i, j],3}   ]");
        }
        System.Console.WriteLine();
    }
}

int SearchCellValues(int[,] array, int row, int col)
{
    int answer = array[row - 1, col - 1];//нумерация столбцов и строк с 1.
    return answer;
}


int[,] table = CreateMatrixRndInt(4, 4, 0, 9);
PrintMatrix(table);
Console.WriteLine("Программа находит значние ячейки данной таблицы");
Console.Write("Введите номер строки нужной вам ячейки: ");
int RowPositionCell = Convert.ToInt32(Console.ReadLine());
while (RowPositionCell > table.GetLength(0))
{
    Console.Write("Такой строки в таблице нет, повторите ввод строки: ");
    RowPositionCell = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Введите номер столбца нужной вам ячейки: ");
int colPositionCell = Convert.ToInt32(Console.ReadLine());
while (colPositionCell > table.GetLength(1))
{
    Console.Write("Такого столбца в таблице нет, повторите ввод столбца: ");
    colPositionCell = Convert.ToInt32(Console.ReadLine());
}
int value = SearchCellValues(table, RowPositionCell, colPositionCell);
System.Console.WriteLine(value);