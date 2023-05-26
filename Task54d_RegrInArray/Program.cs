// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:      // 1 4 7 2
                                // 5 9 2 3
                                // 8 4 2 4
// В итоге получается вот такой массив: // 7 4 2 1
                                        // 9 5 3 2
                                        // 8 4 4 2

// вариант 1
Console.Write("Введите размерность m массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m,n];

void Massive(int m, int n)
{
    int i,j;
    Random random = new Random();
    for (i = 0; i < m; i++)
    {
        for (j = 0; j < n; j++)
        {
        randomArray[i,j] = random.Next(1, 10); // или randomArray[i,j] = new Random().Next(1, 10);
        }
    }
}

void PrintMassive(int[,] array)
{
    int i,j;
    for (i = 0; i < array.GetLength(0); i++)
    {
    // Console.WriteLine();
        for (j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
            Console.WriteLine();
    }
}

Massive(m,n);
///Console.WriteLine("\nИсходный массив: ");
Console.WriteLine("Исходный массив: ");
PrintMassive(randomArray);

// Сортировка элементов в строки массива по убыванию
void Decrease(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

Decrease(randomArray);
Console.WriteLine("\nОтсортированный массив: ");
PrintMassive(randomArray);


// Вариант 2
// int [,] array = new int[3, 4];

// // заполение 2-мерного массива
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(1, 10);
//     }
// }

// // Вывод двумерного массива
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();

// // Сортировка элементов в строке 2-мерного массива по убыванию
// void Decrease(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     } Console.WriteLine(array);
// }

// Decrease(array);
// Console.WriteLine("\nОтсортированный массив: ");
// Console.WriteLine(array);
// Print(array);
