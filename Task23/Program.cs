// Задача 3. Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

// 14  ->  нет
// 46  ->  нет
// 161 ->  да

Console.WriteLine("Программа определения кратного и некратного");

Console.WriteLine("Введите делимое");
int a = Convert.ToInt32(Console.ReadLine());
int b = 7;
int c = 23;

// или можно писать ввод из консоли так:
// string text_a = Console.ReadLine();
// int a = int.Parse(text_a);

if (a % b == 0 && a % c == 0) {
    Console.WriteLine(a + " кратно " + b + " и " + c);
} else {
    Console.WriteLine(a + " не кратно " + b + " и " + c);
}

// или ещё вариант решения
// if(a / b == 0)
    // { if(a / c == 0)
    //     Console.WriteLine("Победа!");
    // } else {
    //     Console.WriteLine("Победа, но другая...");
    // }