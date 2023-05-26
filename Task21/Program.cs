// Условные выражения:
// > - больше
// >= - больше либо равно
// < - меньше
// <= - меньше либо равно

// Логическое ИЛИ - выполняется одно из условий
// int x = 11;
// if (x == 5 || x > 10)
// {
//     Console.WriteLine("Победа!");
// }
// else {
//     Console.WriteLine("Тоже победа, но другая");
// }


// ! - логическое НЕ - если было true, станет false и наоборот
// int x = 11;
// if (x == 5 || x > 10)
// {
//     Console.WriteLine("Победа!");
// }
// else {
//     Console.WriteLine("Тоже победа, но другая");
// }

// Напишите программу, которая выводит случайное число из отрезка 

// int number = new Random().Next(10, 100); // от 10 включительно до 100 не включительно
// Console.WriteLine("Случайное число")

Console.WriteLine("Вводим 3-значное число");
int n1 = new Random().Next(100, 1000);
Console.WriteLine(n1);
int cut_second_char = (n1 % 10) + ((n1 / 100) * 10);
Console.WriteLine (cut_second_char);

