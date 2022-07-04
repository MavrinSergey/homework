//Задача 30: Напишите программу, которая
//выводит массив из 8 элементов, заполненный
//нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]
Console.Write("Введите длину бинарного кода: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
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

int[] array = FillArray(n);
PrintArray(array);