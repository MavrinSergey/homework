//Задача 41: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) System.Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else System.Console.Write(array[i] + "]");
    }
}

int PositiveNumberCounter(int[] myArray)
{
    int count = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] > 0) {count += 1;}
    }
    return count;
}

System.Console.WriteLine("Программа считает сколько чисел больше 0 ввел пользователь");
System.Console.WriteLine("Введите кол-во чисел которые хотите ввести");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray;
int count = 0;

myArray = new int[size];
System.Console.WriteLine("Введите числа через Entry:");
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = Convert.ToInt32(Console.ReadLine());
}
PrintArray(myArray);
count = PositiveNumberCounter(myArray);
System.Console.WriteLine(count);

//ввод в одну строку
string[] iput = System.Console.ReadLine().Split().ToArray();