// Задача 64: Задайте значение N. Напишите программу, которая
// выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число N = ");
int number = int.Parse(Console.ReadLine());
Console.Write("Все натуральные числа " + MassiveNumber(number, 1));

string MassiveNumber(int number, int end)
{
    if(number == end) return number.ToString();
    return (number + " " + MassiveNumber(number - 1, end));
}

// Вариант 2

// Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// string Recursiya(int start, int end)
// {
//     if (start == end) return start.ToString();
//     if (start > end)
//     {
//         return (start + " " + Recursiya(start - 1, end));
//     }
//  return (start + " "+ Recursiya(start + 1, end));

// }

// Console.WriteLine(Recursiya(N, 1));
// --------------------------------------------------------


// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Метод рекурсии вычисляет сумму чисел от M до N
//  int GetSum(int m, int n)
// {
//     if (n > m)
//         return n + GetSum(m, n - 1);
//     return m;
// }

// // Чтение данных из консоли
// int ReadData(string line)
// {
//     Console.Write(line);
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     return number;
// }

// // Метод выводит результат пользователю
// void PrintData(string msg, int res)
// {
//     Console.WriteLine(msg + res);
// }

// // Основной код программы
// // 1  Вводим данные
// int m = ReadData("Введите число M: ");
// int n = ReadData("Введите число N: ");

// // 2 Считаем сумму
// int sum = GetSum(m,n);

// // 3 Выводим результат
// PrintData("Сумма элементов от М до N равна: ", sum);
// Console.ReadKey();


// Вариант 2
System.Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine());
System.Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());

int SumNumbers(int numStart, int numEnd) 
{
    if (numEnd < numStart)
    {
        Console.WriteLine("Неверное условие");
        return -1;
    }
    if (numStart == numEnd)
    {
        return numStart;
    }
    else
    {
        return numStart + SumNumbers(numStart + 1, numEnd);
    }
}

int sum = SumNumbers(m, n);
Console.WriteLine($"Сумма чисел от {m} до {n} равна {sum}");