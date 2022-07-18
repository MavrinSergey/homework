// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8
//в условии по убыванию в примере по возрастанию.Делаем как в условии
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

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[ ");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j]} ");
            else Console.Write($"{array[i, j]} ]");
        }
        Console.WriteLine();
    }
}

void SortDescendingMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp = matrix[i,0];
        for (int j = 0; j < matrix.GetLength(0) - 1; j++)
        {
            for (int k = j + 1; k < matrix.GetLength(0); k++)
            {
                if (matrix[i, j] < matrix[i, k])
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}

Console.WriteLine("Программа упорядочивает по убыванию элементы каждой строки двухмерного массива.");
Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int cok = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте нужный диапазон чисел.");
Console.Write("Нижняя граница диапазона: ");
int begin = Convert.ToInt32(Console.ReadLine());
Console.Write("Верхняя граница диапазона: ");
int end = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateMatrixRndInt(row, cok, begin, end);
PrintMatrix(array);
SortDescendingMatrix(array);
Console.WriteLine();
PrintMatrix(array);