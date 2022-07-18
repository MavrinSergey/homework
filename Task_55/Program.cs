// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

int[,] ChangeRow(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    int[,] swapArray = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            swapArray[i, j] = array[j, i];
        }
    }
    return swapArray;
}


Console.WriteLine("Программа меняет строки на столбцы.");
Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
if (col == row)
{
    Console.WriteLine("Задайте нужный диапазон чисел.");
    Console.Write("Нижняя граница диапазона: ");
    int begin = Convert.ToInt32(Console.ReadLine());
    Console.Write("Верхняя граница диапазона: ");
    int end = Convert.ToInt32(Console.ReadLine());

    int[,] array = CreateMatrixRndInt(row, col, begin, end);
    PrintMatrix(array);
    int[,] arrayResult = ChangeRow(array);
    Console.WriteLine();
    PrintMatrix(arrayResult);
}
else
{
    System.Console.WriteLine("не возможно заменить строки на столбы замените размер матрицы");
}