// Задача 25:
// Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)         2, 4 -> 16

    // Вариант 1
Console.WriteLine("Программа возведения числа в степень");
Console.WriteLine("Введите исходное число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите показатель степени: ");
int degree = Convert.ToInt32(Console.ReadLine());

    double degreedNumber = Math.Pow(n, degree);

Console.WriteLine(degreedNumber);

    // Вариант 2
// Console.WriteLine("Программа возведения числа в степень");
// Console.WriteLine("Введите исходное число и степень: (число, степень)");

// double GetDegree(int n, int degree)
// {
//     double degreedNumber = Math.Pow(n, degree);
//     return degreedNumber;
// }
// double degreedNumber = GetDegree(3, 3);
// Console.WriteLine(degreedNumber);

    // Вариант 3
// Console.WriteLine("Программа возведения числа в степень");
// Console.WriteLine("Введите исходное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите показатель степени: ");
// int degree = Convert.ToInt32(Console.ReadLine());

// double degreedNumber = n;

// for(int i = 0; i < degree - 1; i++) {
//     degreedNumber *= n;
// }

// Console.WriteLine(degreedNumber);