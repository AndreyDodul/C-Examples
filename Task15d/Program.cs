// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да      7 -> да     1 -> нет

Console.WriteLine("Введите номер дня недели от 1 до 7: ");
string text = Console.ReadLine();
int number = Convert.ToInt32(text);
string a = " - рабочий день";
string b = " - ВЫХОДНОЙ !!!";

if (number == 1)
{
    Console.WriteLine("Понедельник" + a);
}
else if (number == 2)
{
    Console.WriteLine("Вторник" + a);
}
else if (number == 3)
{
    Console.WriteLine("Среда"+ a);
}
else if (number == 4)
{
    Console.WriteLine("Четверг" + a);
}
else if (number == 5)
{
    Console.WriteLine("Пятница" + a);
}
else if (number == 6)
{
    Console.WriteLine("Суббота" + b);
}
else if (number == 7)
{
    Console.WriteLine("Воскресенье" + b);
}
else
{Console.WriteLine("Введено некорректное число!");
}