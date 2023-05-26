// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//  452 -> 11       82 -> 10        9012 -> 12

Console.WriteLine("Программа, определяющая сумму цифр числа");
Console.WriteLine("Введите исходное число: ");
int number = Convert.ToInt32(Console.ReadLine());

    int sumOfDigits = 0;
    while (number > 0)
    {
        sumOfDigits = sumOfDigits + number % 10;
        number = number / 10 ;
    }

Console.WriteLine("Сумма цифр введённого числа = " + sumOfDigits);


    // ЧЕРНОВИК
// Console.WriteLine("Программа, определяющая сумму цифр числа");
// Console.WriteLine("Введите исходное число: ");

// //int number = Convert.ToInt32(Console.ReadLine());

// int SumOfDigits(int number)
// {
// //    int number = int.Parse(Console.ReadLine());
//         int sumDigits = 0;
//         while (number > 0)
//         {
//             sumDigits = sumDigits + number % 10;
//             number = number / 10 ;
//             return sumDigits;
//         }
// sumDigits = SumOfDigits(453);
// Console.WriteLine(sumDigits);
// }
// Console.WriteLine(" ");