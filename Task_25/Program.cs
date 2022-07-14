//Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Exponentiation(int num, int degree)
{
    int result = num;

    for (int i = 1; i < degree; i++)
    {
        result = result * num;
    }
    return result;

}


Console.WriteLine("Программа возводит число в степень.");
Console.Write("Введите число которое будем возводить в степень: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степнь числа в которую будем возводить: ");
int b = Convert.ToInt32(Console.ReadLine());

int multiplication = Exponentiation(a, b);
Console.Write(multiplication);
