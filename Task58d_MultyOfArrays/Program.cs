// Задача 58: Задайте два двумерных массива (от 0 до 10). Напишите программу,
// которая будет находить произведение двух массивов (поэлементное).
// Например, даны 2 массива:
// 2 4      // 3 4      // Результирующая матрица будет:    // 6 16
// 3 2      // 3 3                                          // 9 6

// вариант 1
Console.Write("Введите количество строк массива: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int col = int.Parse(Console.ReadLine());

int[,] m1 = new int[row, col];
int[,] m2 = new int[row, col];
int[,] m3 = new int[row, col];
Random random = new Random();

// Заполнение случайными числами
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        m1[i, j] = random.Next(10);     // random.Next(максимально допустимое значение);
        Console.Write(m1[i, j] + " ");  // вывод в консоль массива 1
    }
Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        m2[i, j] = random.Next(10);
        Console.Write(m2[i, j] + " ");  // вывод в консоль массива 2
    }
Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        m3[i, j] = m1[i, j] * m2[i, j]; // Перемноженный массив
    }
}

Console.WriteLine("Произведение двумерных матриц m1 и m2: ");
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        Console.Write(m3[i, j] + " "); // вывод перемноженной матрицы
    }
    Console.WriteLine();
}
Console.ReadKey();
    

// вариант 2
// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine());
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine($"Минимальный элемент находится -> {string.Join(" ", GetIndexMinEl(array))}");
// Console.WriteLine();
// var indexes = GetIndexMinEl(array);
// var resultArray = GetResultArray(array, indexes);
// PrintArray(resultArray);

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return result;
// }

// int[] GetIndexMinEl(int[,] inArray)
// {
//     int[] result = new int[] { 0, 0 };
//     int min = inArray[0, 0];
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             if (min > inArray[i, j])
//             {
//                 min = inArray[i, j];
//                 result[0] = i;
//                 result[1] = j;
//             }
//         }
//     }
//     return result;
// }

// int[,] GetResultArray(int[,] inArray, int[] indexes)
// {
//     int[,] result = new int[inArray.GetLength(0) - 1, inArray.GetLength(1) - 1];
//     int row = 0;
//     int column = 0;
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         if (i == indexes[0]) continue;
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             if (j == indexes[1]) continue;
//             result[row, column] = inArray[i, j];
//             column++;
//         }
//         column = 0;
//         row++;
//     }
//     return result;
// }


// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }