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