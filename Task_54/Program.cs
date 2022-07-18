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

void SortDescendingRow(int[,] array)
{    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            if(array[i,j] > array[i,j-1]);
            else
            {
                int temp = array[i,j];
                array[i,j] = array[i,j-1];
                array[i,j-1] = temp;
            }
        }
    }
}


Console.WriteLine("Программа упорядочивает по убыванию элементы каждой строки двухмерного массива.");
Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте нужный диапазон чисел.");
Console.Write("Нижняя граница диапазона: ");
int begin = Convert.ToInt32(Console.ReadLine());
Console.Write("Верхняя граница диапазона: ");
int end = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateMatrixRndInt(row, col, begin, end);
PrintMatrix(array);
SortDescendingRow(array);
Console.WriteLine();
PrintMatrix(array);