Console.WriteLine("Программа определит, является ли число ЧЁТНЫМ");

Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0) {
    Console.WriteLine("Число " + a + " - ЧЁТНОЕ");
} else
{ Console.WriteLine("Число " + a + " - Нечётное");}

Console.WriteLine("Спасибо!");