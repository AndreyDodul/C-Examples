// Задача 1:
// Напишите программу, которая принимает на вход число N и выдаёт сумму чисел от 1 до N.
//  7 -> 28     4 -> 10     8 -> 36

// Вариант 1
// Console.WriteLine("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// int i = 0;
// while (i <= N)
// {
//     sum = sum + i;
//     i++;
// }

// Console.WriteLine(sum);

// Вариант 2
// int GetSum(int number)
// {
//     int i = 1;
//     int sum = ((i + number) * number) /2;
    
//     return sum;
// }
// int sumNumber = GetSum(5);
// Console.WriteLine(sumNumber);


// Задача 2:
// Напишите программу, принимающую на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24      5 -> 120

// Console.WriteLine("Введите число N: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int factorial = 1;
// int i = 1;
// while (i <= number) {
//     factorial = factorial * i;
//     i++;
// }

// Console.WriteLine(factorial);


// Вариант 2
// int GetFactorial(int number)
// {
//     int factorial = 1;
//     int count = 1;
//     for(factorial = 1; count <= number; count++)
//         factorial = factorial * count;
//         count++;
//     return factorial;
// }

//  int multiply = GetFactorial(5);
//  Console.WriteLine(multiply);

// Вариант 3
// int GetFactorial(int number)
// {
//     if(number == 1) return 1;
    
//     return number * GetFactorial(number - 1);
// }

// int multiply = GetFactorial(4);
// Console.WriteLine(multiply);


// Задача 3
// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
void FillArray(int[] array)
{
    int index = 0;
    while (index < array.Length)
    {
        array[index] = new Random().Next(0, 2); // 0 и 1
        index++;
    }
}

void PrintArray(int[] array)
{
    int index = 0;
    while (index < array.Length)
    {
        Console.Write(array[index] + " ");
        index++;
    }
}

int[] array_1 = new int[8];

FillArray(array_1);
PrintArray(array_1);