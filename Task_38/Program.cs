//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int[] CreatArray(int size, int begin, int end)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(begin, end + 1);
    }
    return array;
}

void PrintArray(int[] array) //печатает массив
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) System.Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else System.Console.Write(array[i] + "]");
    }
}

int MaxNum(int[] array)//ищет максимум
{
    int max = array[0];
    for (int i = 1; i < array.Length-1; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

int MinNum(int[] array)//ищет минимум
{
    int min = array[0];
    for (int i = 1; i < array.Length-1; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}


//начало программы
Console.WriteLine("Программа считает разницу максимального и минимального элементов в массиве.");
Console.Write("Задайте длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте нужный диапазон чисел.");
Console.Write("Нижняя граница диапазона: ");
int begin = Convert.ToInt32(Console.ReadLine());
Console.Write("Верхняя граница диапазона: ");
int end = Convert.ToInt32(Console.ReadLine());

int[] MyArray = CreatArray(size, begin, end);//создали массив
PrintArray(MyArray);//печатаем наш массив
int max = MaxNum(MyArray);// максимум
int min = MinNum(MyArray);// минимум
System.Console.WriteLine(max-min);// разница