// Задача 2: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:

// 1 4 7 2
// 5 9 2 3
// 8 3 2 9

// Новый массив будет выглядеть вот так:

// 1 4 49 2
// 5 9 2 9
// 64 3 4 9

// заполняем массив
int m = 3;
int n = 4;
int[,] array = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
       array[i, j] = new Random().Next(0, 10);
    }
}

// выводим массив
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

// возводим элементы в степень
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
        {
            array[i, j] = array[i, j] * array[i, j];
        }
    }
}
Console.WriteLine();


// выводим возведенный в степень массив
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}


// Задача 1: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.

// m = 3, n = 4.

// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


// // заполняем массив
// int m = 3;
// int n = 4;
// int[,] array = new int[m, n];

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//        array[i, j] = i + j;
//     }
// }

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//        Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }
