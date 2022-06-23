//5. Напишите программу, которая на вход принимает
//одно число (N), а на выходе показывает все целые
//числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> " -2, -1, 0, 1, 2"

Console.Write("Введите целое число: "); 
int num = Convert.ToInt32(Console.ReadLine());
int negnum;
if (num > 0) {
    negnum = num * -1;
}
else { 
    negnum = num;
    num = negnum * -1;
}
while (negnum <= num) {
    Console.Write($" {negnum} ");
    negnum ++;
}

//Console.Write("Введите целое число: ");
//int num = Convert.ToInt32(Console.ReadLine());
//for (int index = -num; index <= num; index++)
//{
//    Console.Write($" {index} ");
//}

