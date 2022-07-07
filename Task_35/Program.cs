//Задача 35: Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в
//отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
//123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

int[] Creat(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 150);
    }
    return array;
}

int Search(int[] array, int begin, int end)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= begin && array[i] <= end) count++;
    }
    return count;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) System.Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else System.Console.Write(array[i] + "]");
    }
}

int[] resArray = Creat(123);
PrintArray(resArray);
System.Console.WriteLine(Search(resArray, 10, 99));