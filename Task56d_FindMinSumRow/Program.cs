// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
    // Например, задан массив:  // 1 4 7 2
                                // 5 9 2 3
                                // 8 4 2 4
                                // 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с
// наименьшей суммой элементов: 1 строка

// вариант 1
int[,] CreateMatrix (int row, int col, int min, int max) 
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();   
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min, max +1);
        }
    }
    return matrix;
} 

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i <  matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            if (j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 1}|");
            else Console.Write($"{matrix[i, j], 1}");
        }
        Console.WriteLine("|");        
    }        
}

void SumStringMatrix(int[,] matrix)
{
    int index = 0, minsum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        Console.WriteLine($"Сумма чисел {i + 1}-й строки = {sum}");
        if (i == 0)
        {
            minsum = sum;
        }
        else if (sum < minsum)
        {
            sum = minsum;
            sum += minsum;   //
            index = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Минимальная сумма чисел в строке {index + 1}. ");            
}

int[,] array2D = CreateMatrix(3, 3, 0, 10);
PrintMatrix(array2D);
SumStringMatrix(array2D);
// -------------------------------------------

// вариант 2
// Console.Write("Введите количество строк и столбцов m массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = m;
// int[,] randomArray = new int[m,n];

// void Massive(int m, int n)
// {
//     int i,j;
//     for (i = 0; i < m; i++)
//     {
//         for (j = 0; j < n; j++)
//         {
//         randomArray[i,j] = new Random().Next(1, 10); // или randomArray[i,j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintMassive(int[,] array)
// {
//     int i,j;
//     for (i = 0; i < array.GetLength(0); i++)
//     {
//         for (j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} ");
//         }
//             Console.WriteLine();
//     }
// }

// Massive(m,n);
// Console.WriteLine("Исходный массив: ");
// PrintMassive(randomArray);

// // Поиск строки с наименьшей суммой
// Console.WriteLine("Сумма каждой строки: ");
// void RowSum(int[,] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//         // sum += Math.Abs(array[i,j]);
//         sum[j] += array[i,j];
//         }
//     Console.WriteLine("{0} - sum = {1:F3}", i, sum);
//         sum = 0;
//     }
// }

// RowSum(int[,] array);
// PrintMassive(randomArray);
// Console.WriteLine("\nНаименьшая сумму элементов строки: ");
