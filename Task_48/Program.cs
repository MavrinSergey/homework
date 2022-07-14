// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] CreateMatrixRndInt(int row, int col)
{
     int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i+j;
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
            if (j == 0) System.Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write(array[i,j] + ",");
            else System.Console.Write(array[i,j] + "]");
        }
        System.Console.WriteLine();
    }
}

int[,] arrayResult = CreateMatrixRndInt(5,6);
PrintMatrix(arrayResult);
