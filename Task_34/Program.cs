//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] CreatArray(int size) //задает массив
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
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

int CountEvenNum(int[] array) //считает кол-во четных чисел
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count ++;
        }
    }
    return count;
}

Console.WriteLine("Программа показывает количество чётных чисел в массиве");
Console.Write("Задайте длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] resArray = CreatArray(size);//задаем массив
PrintArray(resArray);//печатаем заданный массив
System.Console.Write(" -> ");//печатаем разделитель
System.Console.Write(CountEvenNum(resArray));//печатаем ответ