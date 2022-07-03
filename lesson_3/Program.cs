// Вид 1
void Method1()//ни чего не возвращают ни чего не принимают
{
    Console.WriteLine("Fdnjh..");
}
//Method1();











//Вид 2
void Method2(string msg)//ни чего не возвращают но могут принимать какие то данные
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения");

void Method21(string msg, int count)//ни чего не возвращают но могут принимать какие то данные
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg:"Текст сообщения", count: 4);








//Вид 3 что то возвращают но ни чего не принимают

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);










// Вид 4 Что то принимают и что то возвращают
string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
//string res = Method4(10, "ghfghf");
//Console.WriteLine(res);

//for (int i = 2; i <=10; i++)
//{
//    for (int j = 2; j<=10; j++)
//    {
//        Console.WriteLine($"{i} x {j} = {i * j}");
//    }
//    Console.WriteLine();
//}

//string text = "ghjhgjhgjgh ghjfgjh fhhtyuhn fhyjghj jhgj";
//string Replace(string text, char oldValue, char newValue)
//{
//    string result = String.Empty;
//
//    int length = text.Length;
//    for (int i = 0; i < length; i++)
//    {
//        if(text[i] == oldValue) result = result + $"{newValue}";
//        else result = result + $"{text[i]}";
//    }
//    return result;
//}
//string newText = Replace(text, ' ', '|');
//Console.WriteLine(newText);







int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array) // печатает массив
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array) // упорядывачивает масив по возрастанию
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);