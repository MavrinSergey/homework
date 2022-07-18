// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.


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
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j]} ");
            else System.Console.Write($"{array[i, j]} ]");
        }
        System.Console.WriteLine();
    }
}

void ChangeRow(int[,] array)
{
    int indx1 = 0;
    int indx2 = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int row = array[indx1, i];
        array[indx1, i] = array[indx2, i];
        array[indx2, i] = row;
    }
}

Console.WriteLine("Программа меняет первую строку с последней таблици.");
Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте нужный диапазон чисел.");
Console.Write("Нижняя граница диапазона: ");
int begin = Convert.ToInt32(Console.ReadLine());
Console.Write("Верхняя граница диапазона: ");
int end = Convert.ToInt32(Console.ReadLine());

int[,] arrayResult = CreateMatrixRndInt(row, col, begin, end);
PrintMatrix(arrayResult);
ChangeRow(arrayResult);
System.Console.WriteLine();
PrintMatrix(arrayResult);