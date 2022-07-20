// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

Console.Clear();
int[,] CreateMatrix(int row, int col)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
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

int[] SearchMinElem(int[,] matrix)
{
    int[] array = new int[2];
    int min = 11;
    int row = matrix.GetLength(0)-1;
    int col = matrix.GetLength(1)-1;
    for (int i = 0; i <= row; i++)
    {
        for (int j = 0; j <= col; j++)
        {
            if (min > matrix[i, j])
            {
                min = matrix[i, j];
                array[0]=i;
                array[1]=j;
            }
        }
    }
    return array;
}

int[,] ModificMatrix(int[,] matrix, int x, int y)
{
    int[,] massiv = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            if (i < x && j < y)
                massiv[i, j] = matrix[i, j];
            else if (i < x && j >= y)
                massiv[i, j] = matrix[i, j + 1];
            else if (i >= x && j < y)
                massiv[i, j] = matrix[i + 1, j];
            else if (i >= x && j >= y)
                massiv[i, j] = matrix[i + 1, j + 1];
        }
    }
    return massiv;
}

Console.WriteLine("Программа удалит строку и столбец на пересечении которых стоит наименьший элемент.");
Console.WriteLine("Введите параметр матрицы.");
int[,] myMatrix = CreateMatrix(4, 4);
PrintMatrix(myMatrix);
System.Console.WriteLine();
int[] myNumRowCol = SearchMinElem(myMatrix);
int[,] myModificMatrix = ModificMatrix(myMatrix, myNumRowCol[0], myNumRowCol[1]);
Console.WriteLine(myNumRowCol[0]);
Console.WriteLine(myNumRowCol[1]);
PrintMatrix(myModificMatrix);
