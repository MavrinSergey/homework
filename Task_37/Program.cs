//Задача 37: Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний
//и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

int[] MularrEl (int[] array)
{
    int len = 0;
    if (array.Length % 2 == 0) len = array.Length / 2;
    else len = array.Length / 2 +1;
    int[] ResArr = new int[len];
    for (int i = 0; i < len; i++)
    {
        ResArr[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 != 0) ResArr[len-1] = array[len-1];
    
    return ResArr;
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

int[] Creat(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 11);
    }
    return array;
}
int[] generr = Creat(10);
int[] resArr =  MularrEl(generr);

PrintArray(generr);
PrintArray(resArr);