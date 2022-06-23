//Напишите программу, которая будет выдавать 
//название дня недели по заданному номеру

Console.Write("Введите номер дня чтоб узнать названия дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1) {
    Console.Write("Понедельник");
}
if (num == 2) {
    Console.Write("Вторник");
}
else if (num == 3) {
    Console.Write("Среда");
}
else if (num == 4) {
    Console.Write("Четверг");
}
else if (num == 5) {
    Console.Write("Пятница");
}
else if (num == 6) {
    Console.Write("Суббота");
}
else if (num == 7) {
    Console.Write("Воскресенье");
}
else {
    Console.Write("Нет такого дня");
}
