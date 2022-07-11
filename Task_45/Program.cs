//Задача 45: Напишите программу, которая будет создавать
//копию заданного массива с помощью поэлементного
//копирования.

int[] CreatArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) System.Console.Write("[");
        if (i < array.Length -1) Console.Write(array[i] + ",");
        else System.Console.Write(array[i] + "]");
    }
}

int[] CopyOfArray(int[] array)
{
    int[] copy = new int[array.Length];
    for (int i = 0; i < copy.Length; i++)
    {
        copy[i] = array[i];
    }
    return copy;
}

int[] MyArray = CreatArray(5);
PrintArray(MyArray);
System.Console.WriteLine();
int[] copy = CopyOfArray(MyArray);
PrintArray(copy);