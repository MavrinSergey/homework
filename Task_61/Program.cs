//  Задача 61: Вывести первые N строк треугольника Паскаля.
//  Сделать вывод в виде равнобедренного треугольника.

int Factorial(int n)
{
    int x = 1;
    for (int i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}

void PrintPasc(int rowCol)
{
    int j;
    for (int i = 0; i < rowCol; i++)
    {
        if (i < 10) Console.Write($" {i}:");
        else Console.Write($"{i}:");
        for (j = 0; j <= (rowCol - i); j++)
        {
            Console.Write("  ");
        }
        for (j = 0; j <= i; j++)
        {
            Console.Write(" ");
            int element = (Factorial(i) / (Factorial(j) * Factorial(i - j)));
            if (element < 10) Console.Write($"00{element}");
            else if (element < 100) Console.Write($"0{element}");
            else Console.Write(element);
        }
        Console.WriteLine();
    }
}

System.Console.WriteLine("Введите кол-во строк треугольника Паскаля");
int num = Convert.ToInt32(Console.ReadLine());
PrintPasc(num);
