// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
int[,] CreateMatrixB(int[,] matrix) // не придумал как по другому проверку провести
{
    Console.Write("Введите кол-во строк: ");
    int row = Convert.ToInt32(Console.ReadLine());
    while (row != matrix.GetLength(1))
    {
        Console.WriteLine("Кол-во строк во второй матрице должно быть равно кол-ву столбцов в первой матрице.");
        Console.Write("Введите кол-во строк еще раз: ");
        row = Convert.ToInt32(Console.ReadLine());
    }
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

int[,] MultiplicationMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i < matrixC.GetLength(0); i++)
    {

        for (int j = 0; j < matrixC.GetLength(1); j++)
        {
            int sumMultiplication = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                sumMultiplication = sumMultiplication + matrixA[i, k] * matrixB[k, j];
            }
            matrixC[i, j] = sumMultiplication;
        }
    }
    return matrixC;
}


Console.WriteLine("Программа перемножает две матрицы.");
Console.WriteLine("Введите параметры первой матрицы.");
int[,] myMatrixA = CreateMatrix();
FillingMatrix(myMatrixA);

Console.WriteLine("Введите параметры второй матрицы.");
int[,] myMatrixB = CreateMatrixB(myMatrixA);
FillingMatrix(myMatrixB);

int[,] myMatrixC = MultiplicationMatrix(myMatrixA, myMatrixB);
PrintMatrix(myMatrixA);
System.Console.WriteLine();
PrintMatrix(myMatrixB);
System.Console.WriteLine();
PrintMatrix(myMatrixC);