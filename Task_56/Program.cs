// Задача 56: Задайте двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
int[,] CreateMatrixRndInt(int row, int cok, int min, int max)
{
    int[,] array = new int[row, cok];
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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[ ");
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]} ");
            else Console.Write($"{matrix[i, j]} ]");
        }
        Console.WriteLine();
    }
}

int[] SumsRow(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        array[i] = sum;
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) System.Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else System.Console.Write(array[i] + "]");
    }
}

int NumMinNumArray(int[] array)
{
    int min = array[0];
    int indx = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            indx = i + 1;
        }
    }
    return indx;
}

Console.WriteLine("программа, которая находит строку в массиве с наименьшей суммой элементов.");
Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int cok = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте нужный диапазон чисел.");
Console.Write("Нижняя граница диапазона: ");
int begin = Convert.ToInt32(Console.ReadLine());
Console.Write("Верхняя граница диапазона: ");
int end = Convert.ToInt32(Console.ReadLine());

int[,] myMatrix = CreateMatrixRndInt(row, cok, begin, end);
PrintMatrix(myMatrix);
int[] myArray = SumsRow(myMatrix);
Console.WriteLine();
PrintArray(myArray);
int minSum = NumMinNumArray(myArray);
Console.WriteLine();
Console.WriteLine($"{minSum} строка с наименьшей суммой элементов");