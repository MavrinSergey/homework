//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] CreatArray(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * 10;
    }
    return array;
}

void PrintArray(double[] array) //печатает массив
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) System.Console.Write("[");
        if (i < array.Length - 1) Console.Write(Math.Round(array[i], 2) + "; ");
        else System.Console.Write(Math.Round(array[i], 2) + "]");
    }
}

double MaxNum(double[] array)//ищет максимум
{
    double max = array[0];
    for (int i = 1; i < array.Length - 1; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

double MinNum(double[] array)//ищет минимум
{
    double min = array[0];
    for (int i = 1; i < array.Length - 1; i++)
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
//Console.WriteLine("Задайте нужный диапазон чисел.");
//Console.Write("Нижняя граница диапазона: ");
//double begin = Convert.ToDouble(Console.ReadLine());
//Console.Write("Верхняя граница диапазона: ");
//double end = Convert.ToDouble(Console.ReadLine());

double[] MyArray = CreatArray(size);//создали массив
PrintArray(MyArray);//печатаем наш массив
double max = MaxNum(MyArray);// максимум
double min = MinNum(MyArray);// минимум
System.Console.WriteLine(Math.Round(max - min, 2));// разница