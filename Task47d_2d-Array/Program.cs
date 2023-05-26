// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами от -10,0 до 10,0.
// m = 3, n = 4:                // 0,5 7,0 -2,0 -0,2
                                // 1,0 -3,3 8,0 -9,9
                                // 8,0 7,8 -7,1 9,0

double[,] array = new double[3, 4];

// заполение 2-мерного массива
Random random = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = Math.Round(random.Next(-100, 100)*0.1, 2);
    }
}

// Вывод двумерного массива
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();