void FillArray(int[] collection) 
{
    int length = collection.Length;
    int index = 0;
    while (index < length) 
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) 
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}


int IndexOf(int[] collection, int find) 
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find) 
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);

int[] CreatndInt(int size, int begin, int end)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(begin, end + 1);
    }
    return array;
}




int[] GetSumNegPosElem(int[] array)
{
    int sumNeg = 0;
    int sumPos = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sumNeg += array[i];
        }
        else
        {
            sumPos += array[i];
        }
    }
    return new int[] { sumNeg, sumPos };
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

int[] resArray = CreateArrayRndInt(12, -9, 9);
PrintArray(resArray);
int[] sumNegPosElem = GetSumNegPosElem(resArray);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма положительных чисел = {sumNegPosElem[1]}");
System.Console.WriteLine($"Сумма отрицательных чисел = {sumNegPosElem[0]}");