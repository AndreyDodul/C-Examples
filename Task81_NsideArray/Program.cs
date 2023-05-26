// Задача 1: Задайте двумерный массив случайных чисел от 0 до 10. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:

// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

int[,] FillArray(int[,] arr, int startRandom, int endRandom)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(startRandom, endRandom + 1);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] arr = new int[3, 4];
FillArray(arr, 1, 10);
PrintArray(arr);

// вариант 1
for (int j = 0; j < arr.GetLength(1); j++)
{
    int temp = arr[0, j];
    arr[0, j] = arr[arr.GetLength(0) - 1, j];
    arr[arr.GetLength(0) - 1, j] = temp;
}
Console.WriteLine();
PrintArray(arr);
// конец вариант 1

// вариант 2
int[,] outArray = new int[arr.GetLength(0), arr.GetLength(1)];
int maxRowIndex = arr.GetLength(0) - 1;
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (i == 0)
        {
            outArray[i, j] = arr[maxRowIndex, j];
        }
        if (i == maxRowIndex)
        {
            outArray[i, j] = arr[0, j];
        }
         outArray[i, j] = arr[i, j];
    }
}
Console.WriteLine();
PrintArray(outArray);
// конец варианта 2
// ----------------------------------------------------------------

    // Задача 2: Из двумерного массива случайных целых чисел от 0 до 10 удалить строку и
    //  столбец, на пересечении которых расположен наименьший элемент.

    // FillArray();
    // PrintArray();

    // int temp = 0;
    // for (int i = 0; i < arrRevers.GetLength(0); i++)
    // {
    //     for (int j = 0; j < arrRevers.GetLength(1); j++)
    //     {
    //         int temp = arrRevers[0, 0];
    //         if(arrRevers[i, j] <= temp)
    //         {
    //             temp = arrRevers[i, j];
    //             Console.WriteLine("[" + temp + "]");
    //         }
    //      // Console.Write();
    //     }
    // // Console.WriteLine();
    // }