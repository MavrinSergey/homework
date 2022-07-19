// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.Clear();

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

int[,] SpiralFilledMatrix(int num)
{
    int[,] matrix = new int[num, num];
    {
        int count = 1;
        int col = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i == 1) col = num - 1;
            for (int j = col; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = count++;
            }
            col = col - 1;
            for (int j = col; j < matrix.GetLength(1); j--)
            {
                matrix[i, j] = count++;
            }

        }

    }
    return matrix;
}



Console.WriteLine("Программа заполняет двухмерный массив по спирали.");
int[,] mySpiralMatrix = SpiralFilledMatrix(3);
PrintMatrix(mySpiralMatrix);