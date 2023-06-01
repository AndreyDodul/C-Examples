Console.WriteLine("Программа определит НАИБОЛЬШЕЕ из 3-х целых чисел");

Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());
int max1 = 0;
int max;

if (a > b) {
    max1 = a;
} 
if (b > a) {
    max1 = b;
}
if (max1 > c)
{ max = max1; }
else {
    max = c;
}

Console.WriteLine("Наибольшее число: " + max);
Console.WriteLine("Спасибо!");