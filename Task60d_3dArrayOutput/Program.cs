// Задача 60. ...Сформируйте 3-мерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы
// каждого элемента.
// Массив размером 2 x 2 x 2        // 66(0,0,0) 25(0,1,0)
                                    // 34(1,0,0) 41(1,1,0)
                                    // 27(0,0,1) 90(0,1,1)
                                    // 26(1,0,1) 55(1,1,1)

// вариант 1
Console.Write("Введите количество строк 3-мерного массива - размерность 1: ");
int dimension1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 3-мерного массива - размерность 2: ");
int dimension2 = int.Parse(Console.ReadLine());
Console.Write("Введите размер глубины 3-мерного массива - размерность 3: ");
int dimension3 = int.Parse(Console.ReadLine());

// Заполнение двумерного массива:
int[,,] array = new int[dimension1, dimension2, dimension3];

// проверка ввода неповторяющегося числа
HashSet<int> numbers = new HashSet<int>();
int CheckUniqueNumber()
{
    while (true)
    {
        int n = new Random().Next(10, 100);
        if (!numbers.Contains(n))
        {
            numbers.Add(n);
            return n;
        }
    }
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for(int k = 0; k < array.GetLength(2); k++)
        {
        // array[i, j, k] = new Random().Next(10, 100); // ввод случайных чисел
        array[i, j, k] = CheckUniqueNumber();   // ввод НЕПОВТОРЯЮЩИХСЯ случайных чисел
        }
    }
}
// // Вывод двумерного массива
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write("|");
        for(int k = 0; k < array.GetLength(2); k++)
        {
            Console.Write($"{array[i, j, k],1}({i},{j},{k})|");
        }
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.ReadKey();
// ------------------------------------------------------------------
// вариант 2
// int[,,] CreateMatrix (int row, int col, int dep, int min, int max) 
// {
//     int[,,] array = new int[row, col, dep];
//     Random random = new Random();
//     for (int i = 0; i < array.GetLength(0); i++) 
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//                 {
//                     array[i,j,k] = random.Next(min, max + 1);
//                 }
//         }
//     }
//     return array;
// } 
 
// void PrintMatrix(int[,,] array)
// {
//     for (int i = 0; i <  array.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < array.GetLength(1); j++) 
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//             Console.Write($"{array[i, j, k],1}({i},{j},{k})|");
//             }
//         }
//         Console.WriteLine();        
//     }        
// }
 
// int[,,] array3D = CreateMatrix(2, 2, 2, 10, 99);
// PrintMatrix(array3D);
// Console.ReadKey();
