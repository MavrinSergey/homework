// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
int[] InputData()
{
    Console.WriteLine("Введите размерность массива.");
    Console.Write("Введите размер оси x: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите размер оси y: ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите размер оси z: ");
    int z = Convert.ToInt32(Console.ReadLine());
    int[] array = { x, y, z };
    return array;
}

int[] CreatArray(int[] array)
{
    int[] temp = new int[array[0] * array[1] * array[2]];
    Random rnd = new Random();
    int tempNum = 0;
    for (int i = 0; i < temp.Length; i++)
    {
        tempNum = rnd.Next(10, 100);
        while (temp.Contains(tempNum))
        {
            tempNum = rnd.Next(10, 100);
        }
        temp[i] = tempNum;
    }
    return temp;
}

int[,,] FilldMatrix(int[] array, int[] inputArray)
{
    int[,,] matrix = new int[inputArray[0], inputArray[1], inputArray[2]];
    int counter = 0;
    for (int i = 0; i < matrix.GetLength(2); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                matrix[j, k, i] = array[counter++];
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
int[] inputData = InputData();
int[] myArray = CreatArray(inputData);
int[,,] myMatrix = FilldMatrix(myArray, inputData);
Console.WriteLine();
PrintMatrix(myMatrix);
// помоему программа некоректно работает если значения x,y,z ввести разные.