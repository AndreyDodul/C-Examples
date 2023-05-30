// Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Вводим 3-значное число:");
int n1 = new Random().Next(100, 1000);
Console.WriteLine(n1);
int left_second_char = n1 % 100 / 10;
Console.WriteLine ("Вторая цифра числа: " + left_second_char);