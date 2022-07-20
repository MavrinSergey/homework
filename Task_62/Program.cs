// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
Console.Clear();
int[] CreateArray(int size)
{
    int[] array = new int[size];
    return array;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[ ");
            if (matrix[i, j] < 10)
            {
                if (j < matrix.GetLength(1) - 1) Console.Write($"0{matrix[i, j]} ");
                else Console.Write($"0{matrix[i, j]} ]");
            }
            else
            {
                if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]} ");
                else Console.Write($"{matrix[i, j]} ]");
            }
        }
        Console.WriteLine();
    }
}

int[,] SpiralFilledMatrix(int[] array)
{
    int[,] matrix = new int[array.Length, array.Length];
    {
        int count = 1;
        int rowRight = matrix.GetLength(0);
        int colRight = matrix.GetLength(1);

        int rowDown = matrix.GetLength(0);
        int colDown = matrix.GetLength(1);

        int rowLeft = matrix.GetLength(0);
        int colLeft = matrix.GetLength(1)-array.Length;

        int rowUp = matrix.GetLength(0)-array.Length;
        int colUp = matrix.GetLength(1)-array.Length;
        int i = 0, j = 0, k = 0;
        for (; k < array.Length*array.Length;)
        {
            for (; j < colRight; j++)
            {
                matrix[i, j] = count++;
                k++;
            }
            i++;
            colRight--;
            for (; i < rowDown; i++)
            {
                matrix[i, colDown - 1] = count++;
                k++;
            }
            colDown--;
            rowDown--;
            j--;
            j--;
            for (; j >= colLeft; j--)
            {
                matrix[rowLeft - 1, j] = count++;
                k++;
            }
            colLeft++;
            rowLeft--;
            i--;
            i--;
            j++;
            for (;i > rowUp; i--)
            {
                matrix[i, colUp] = count++;
                k++;
            }
            rowUp++;
            colUp++;
            j++;
            i++;
        }
    }
    return matrix;
}

Console.WriteLine("Программа заполняет двухмерный массив по спирали.");
int[] myArray = CreateArray(9);
int[,] mySpiralMatrix = SpiralFilledMatrix(myArray);
PrintMatrix(mySpiralMatrix);