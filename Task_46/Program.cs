


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
            if (j == 0) System.Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write(array[i,j] + ",");
            else System.Console.Write(array[i,j] + "]");
        }
        System.Console.WriteLine();
    }
}

int[,] arrayResult = CreateMatrixRndInt(3, 4, 10, 30);
PrintMatrix(arrayResult);