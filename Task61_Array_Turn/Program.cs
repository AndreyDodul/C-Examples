// Напишите программу, которая перевернёт одномерный массив (последний элемент будет
// на первом месте, а первый - на последнем и т.д.).
// Элементы одномерного массива задаются случано и лежат в промежутке от -10 до 10
//  [1 2 3 4 5] -> [5 4 3 2 1]      [6 7 3 6] -> [6 3 7 6]

// double[] array = new double[5];
// for (int i = 0; i < array.Length; i++)
// {
//     double number = new Random().Next(-10, 11) + new Random().NextDouble();
//     array[i] = Math.Round(number, 2);
// }
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }
// // Вариант 1.1
// for (int i = 0; i < array.Length/2; i++)
// {
//     double temp = array[i];
//     array[i] = array[array.Length - i - 1];
//     array[array.Length - i - 1] = temp;
// }
// Вариант 2.1
// double[] result = new double[array.Length]; // сщздаем новый массив, размером с 1-й
// for (int i = 0; i < array.Length; i++)
// {
//     result[i] = array[array.Length - 1 - i]; // записываем каждый последний элемент в первый

// }
// Console.WriteLine();
// for (int i = 0; i < result.Length; i++)
// {
//     Console.Write(result[i] + " ");
// }
// Конец варианта 2.1
// Console.WriteLine();
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }

// вычисление среднего арифметического данного массива
// double[]array = new double[5];
// for(int i = 0; i < array.Length; i++)
// {
//     double randomNumber = new Random().Next(-10, 10) + new Random().NextDouble();
//     array[i] = Math.Round(randomNumber, 2);
//     Console.Write(array[i] + " ");
//     // Console.Write();
// }

// double sum = 0;
// int count = array.Length;
// for(int i = 0; i < array.Length; i++)
// {
//     if(array[i] > 0)
//     {
//         sum = sum + array[i];
//         count++;
//     }
// }

// double result = sum / count;
// Console.WriteLine(" ");
// Console.WriteLine("Среднее арифметическое положительных чисел равно " + sum);


// double AverageArray(int[] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         sum = sum + array[i];
//     }
//     return sum / array.Length;
// }

// int[] array = new int[4];
// //GetRandomArray(array);
// //PrintArray(array);
// Console.WriteLine("Среднее арифметическое данного массива равно: " + AverageArray(array));


// Задча 3. Задайте двумерный массив со случайными числами от -10 до 10. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)
// Например, задан массив:
// 1 4 7 2      5 9 2 3     8 4 2 4

// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] arr = new int[4, 5];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(0, 11);
    }
}

void PrintArray(int[,] array) // Метод позволяет вывести массив в консоль
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++) 
    {
        Console.Write($"{array[i, j]} ");
    }
Console.WriteLine();
}
}

int summ = 0; // переменная хранит в себе сумму чисел главной диагонали 
// Вариант 1
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (j == i)
        {
           summ += arr[i, j];
        }

    }
}

// Вариант 2
// int minSide = arr.GetLength(0);
// if (arr.GetLength(1) < minSide)
// {
//     minSide = arr.GetLength(1);
// }

// for (int i = 0; i < minSide; i++)
// {
//     summ += arr[i, i];
// }

PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"Сумма чисел главной диагонали  = {summ}");
