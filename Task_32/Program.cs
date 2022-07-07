//Задача 32: Напишите программу замена элементов
//массива: положительные элементы замените на
//соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]
//
//int[] array = { -4, -8, 8, 2 };
//
//
//
//
//void PrintArray(int[] array)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        if (i == 0) System.Console.Write("[");
//        if (i < array.Length - 1) Console.Write(array[i] + ",");
//        else System.Console.Write(array[i] + "]");
//    }
//}
//
//PrintArray(array);
//
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = array[i] * -1;
//}
//
//PrintArray(array);

int[] General(int size, int begin, int end)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(begin, end + 1);
    }
    return array;
}




int[] Swap(int[] array)
{
    int[] array = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
}
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) System.Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else System.Console.WriteLine(array[i] + "]");
    }
}

int[] resArray = General(12, -9, 9);
PrintArray(resArray);
resArray = Swap(resArray);
PrintArray(resArray);
