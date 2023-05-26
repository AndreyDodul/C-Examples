Console.WriteLine("Программа определяет длину отрезка по введённым координатам X и Y");
Console.WriteLine("Введите значение х1: ");
string str1 = Console.ReadLine();
int x1 = Convert.ToInt32(str1);
Console.WriteLine("Введите значение y1: ");
string str2 = Console.ReadLine();
int y1 = Convert.ToInt32(str2);
Console.WriteLine("Введите значение х2: ");
string str3 = Console.ReadLine();
int x2 = Convert.ToInt32(str3);
Console.WriteLine("Введите значение y2: ");
string str4 = Console.ReadLine();
int y2 = Convert.ToInt32(str4);

double l = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));

Console.WriteLine("Длина отрезка = " + l);
