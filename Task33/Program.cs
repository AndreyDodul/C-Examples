Console.WriteLine("Программа принимает на вход число N и выдает квадраты от 1 до N");
Console.WriteLine("Введите значение N: ");
string str = Console.ReadLine();
double n = Convert.ToInt32(str);

// вариант 1
// double x = 0;
// double y = 0;

// while (x < n) 
// {
//     y = Math.Pow(x, 2);
//     Console.Write(y);
//     Console.Write(" ");
//     x++;
// }

// вариант 2
Console.Write("Квадраты чисел от 1 до N = " + n + ": ");
for(int i = 1; i <= n; Console.Write("  " + i * i + "  "), i++);