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

int[,] CreateMatrix()
{
    Console.Write("Введите кол-во строк: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во столбцов: ");
    int col = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[row, col];
    return array;
}

void FillingMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"Введите значение {i + 1}-строки {j + 1}-столбца: ");
            matrix[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
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

int[,] DelRowColMinElem(int[,] matrix)
{
    
}


Console.WriteLine("Программа удалит строку и столбец на пересечении которых стоит наименьший элемент.");
Console.WriteLine("Введите параметр матрицы.");
int[,] myMatrix = CreateMatrix();
FillingMatrix(myMatrix);

int[,] resultMatrix = DelRowColMinElem(myMatrix);
PrintMatrix(myMatrix);
System.Console.WriteLine();
PrintMatrix(resultMatrix);
