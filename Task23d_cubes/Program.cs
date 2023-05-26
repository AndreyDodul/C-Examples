Console.WriteLine("Программа принимает на вход число N и выдает таблицу кубов значений от 1 до N");
Console.WriteLine("Введите значение N: ");
string str = Console.ReadLine();
double n = Convert.ToInt32(str);

// вариант 1
double x = 1;
double y = 0;

while (x < n) 
{
    y = Math.Pow(x, 3);
    Console.Write(y);
    Console.Write(" ");
    x++;
}

// вариант 2
// Console.Write("Значения кубов чисел от 1 до N = " + n + ": ");
// for(int i = 1; i <= n; Console.Write("  " + i * i * i + "  "), i++);