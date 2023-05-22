// Задача 50. Напишите программу, которая на вход принимает число, и
// возвращает индексы числа в двумерном массиве или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4              // 17 -> такого числа в массиве нет

// Вариант 1
int m = 3, n = 4;
int wishedNumber = 5; //Искомое число
int[,] array = new int[m, n]; //Массив

bool f = false;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        if (wishedNumber == array[i, j]) { m = i; n = j; f = true; };
        //Console.Write("{0}\t", arr[i, j]);  // увеличивает пробелы между числами при выводе
        Console.Write(array[i, j] + "  ");
    }
    Console.WriteLine();
}
Console.WriteLine();

if (f) {
    Console.WriteLine("Число " + wishedNumber + " найдено. Строка " + (m + 1) + " Столбец " + (n + 1));
}
else {
    Console.WriteLine("Число " + wishedNumber + " в массиве не найдено");
}

// Вариант 2
// int m = 3;
// int n = 4;
// int[,] array = new int[m, n];
// // Random random = new Random();
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(1, 10);
//     }
// }

// // // Вывод двумерного массива
// Console.WriteLine("Полученный 2-мерный массив: ");
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }



// Console.WriteLine("\n Введите число: ");
// int wishedNumber = 5;           // int.Parse(Console.ReadLine());

// for (int i = 0; i < array.Length; i++)
// {
//     for (int j = 0; j < array.Length; j++)
//     {
//         if (array[i, j] == wishedNumber)
//         {   
//             Console.Write($"Число {wishedNumber} есть в массиве");
//         }
//         else
//         {
//         Console.WriteLine($"Числа {wishedNumber} нет в массиве");
//         }
//     }
// }

//------------------------------------------
// int m = 3;
// int n = 4;
// int[,] array = new int[m, n];
// // int[,] FillArray(int[m, n] array, int startRandom, int endRandom)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//         // array[i, j] = new Random().Next(startRandom, endRandom + 1);
//         array[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//         Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Поиск с помощью функции
// bool IsNumberInArray(int wishedNumber, int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         for (int j = 0; j < array.Length; j++)
//         {
//             if (array[i,j] == wishedNumber)
//             {
//             return true;
//             }
//         }
//     }
//     return false;
// }

// int[,] array = new int[m, n];
// array = FillArray(array, 0, 9);
// PrintArray(array);
// Console.WriteLine("\n Введите число: ");
// int wishedNumber = 5;	//int.Parse(Console.ReadLine());
// // bool isInArray = IsNumberInArray(number, array);

// // // Поиск в виде цикла
// bool isInArray = false;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == whishedNumber)
//     {
//         isInArray = true;
//         break;
//     }
// }
// Все операции сравнения и равенства - bool
// 5 > 8 -- тоже bool

// или
// if (IsNumberInArray(number, array))
// if (isInArray)
// {
//     Console.WriteLine($"Число {wishedNumber} есть в массиве");
// }
// else
// {
//     Console.WriteLine($"Числа {wishedNumber} нет в массиве");
// }