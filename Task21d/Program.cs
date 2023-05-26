Console.WriteLine("Программа вычисляет длину отрезка по введённым координатам X, Y и Z");
Console.WriteLine("Введите значение х1: ");
string str1 = Console.ReadLine();
int x1 = Convert.ToInt32(str1);
Console.WriteLine("Введите значение y1: ");
string str2 = Console.ReadLine();
int y1 = Convert.ToInt32(str2);
Console.WriteLine("Введите значение z1: ");
string str3 = Console.ReadLine();
int z1 = Convert.ToInt32(str3);
Console.WriteLine("Введите значение x2: ");
string str4 = Console.ReadLine();
int x2 = Convert.ToInt32(str4);
Console.WriteLine("Введите значение y2: ");
string str5 = Console.ReadLine();
int y2 = Convert.ToInt32(str5);
Console.WriteLine("Введите значение z2: ");
string str6 = Console.ReadLine();
int z2 = Convert.ToInt32(str6);

double l = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));

Console.WriteLine("Длина отрезка в 3d пространстве = " + l);