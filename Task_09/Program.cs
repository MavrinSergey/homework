






int rndNum = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {rndNum}");

//int firstDigit = rndNum / 10;
//int secondDigit = rndNum % 10;
//int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
//Console.WriteLine($"Наибольшая цифра числа {rndNum} => {maxDigit}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (firstDigit == secondDigit) return 0;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit (rndNum);
string result = maxDigit > 0 ? maxDigit.ToString() : "цифры одинаковы";
Console.WriteLine($"Наибольшая цифра числа {rndNum} => {result}");