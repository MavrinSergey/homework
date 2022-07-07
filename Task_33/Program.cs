//Задача 33: Задайте массив. Напишите программу, которая
//определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да

int[] Creat(int size, int begin, int end)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(begin, end + 1);
    }
    return array;
}

bool Search(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (num == array[i]) return true;
    }
    return false;
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

void PrintRes (bool resSearch)
{
    string  res = resSearch ? "Да" : "Нет";
    System.Console.WriteLine(res);
}

int[] resArray = Creat(12, -9, 9);
PrintArray(resArray);
bool ser = Search(resArray, 4);
PrintRes(ser);


