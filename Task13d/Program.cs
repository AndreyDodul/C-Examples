// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Программа выводит 3-ю цифру числа или сообщает, что 3-й цифры нет");
int a = new Random().Next(10, 10000000);
Console.WriteLine("Введено число: " + a);
if(a / 100 == 0) {
    Console.WriteLine("3-й цифры в " + a + " нет.");
}
else {
string str1 = a.ToString();
string str2 = str1.Substring(2, 1);

    Console.WriteLine("3-я цифра введённого числа: " + str2);
}

// Вариант 2
// Console.WriteLine("Программа выводит 3-ю цифру числа или сообщает, что 3-й цифры нет");
// string str1 = Console.ReadLine();
// int a = Convert.ToInt32(str1);

// if (a < 100) 
// {
//     Console.WriteLine("третьей цифры нет");
// }
// if (a > 0 && a < 999)
// {
//     int b = (a % 10);
//     Console.WriteLine("Третья цифра числа: " + b);
// }
// if (a > 1000 && a < 10000)
// {   int b = (a % 100) / 10;
//     Console.WriteLine("Третья цифра числа: " + b);
// }