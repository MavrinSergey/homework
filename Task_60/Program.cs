// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



Console.Clear();
int[,,] CreateMatrix(int x, int y, int z)
{
    int[,,] matrix = new int[x, y, z];
    Random rnd = new Random();
    int[] temp = new int[x * y * z];
    for (int i = 0; i < matrix.GetLength(2); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                matrix[j, k, i] = rnd.Next(10, 100);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(2); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                Console.Write($"{matrix[j, k, i]}");
                Console.Write($"({j},{k},{i}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.WriteLine("Программа создает трехмерный массив.");
int[,,] myMatrix = CreateMatrix(2, 2, 2);
Console.WriteLine();
PrintMatrix(myMatrix);
// вводятся рандомные проверки на повторяющиеся нет