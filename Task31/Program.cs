Console.WriteLine("Программа определяет номер квадранта по значениям X и Y");
Console.WriteLine("Введите значение Х: ");
string str1 = Console.ReadLine();
int x = Convert.ToInt32(str1);
Console.WriteLine("Введите значение Y: ");
string str2 = Console.ReadLine();
int y = Convert.ToInt32(str2);

if (x == 0 || y == 0)
{
    Console.WriteLine("Значение 0 и 0 не вводи");
}

if (x > 0 && y > 0)
{
    Console.WriteLine("Значение " + x + " и " + y + " соответствуют квадранту 1.");
}

if (x > 0 && y < 0)
{
    Console.WriteLine("Значение " + x + " и " + y + " соответствуют квадранту 4.");
}

if (x < 0 && y > 0)
{
    Console.WriteLine("Значение " + x + " и " + y + " соответствуют квадранту 2.");
}

if (x < 0 && y < 0)
{
    Console.WriteLine("Значение " + x + " и " + y + " соответствуют квадранту 3.");
}
