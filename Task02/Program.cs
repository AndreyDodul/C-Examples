Console.WriteLine("Программа определит НАИБОЛЬШЕЕ из 2-х целых чисел");

Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
int max;

if (a > b) {
    max = a;
} else
{ max = b; }

Console.WriteLine("Наибольшее число: " + max);
Console.WriteLine("Спасибо!");