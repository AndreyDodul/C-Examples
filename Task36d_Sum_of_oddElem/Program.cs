// Задайте одномерный массив, заполненный случайными числами (длина массива 5 элементов).
// Найдите сумму элементов, стоящих на нечётных индексах (индексы с нуля).
// [3, 7, 23, 12] -> 19     [-4, -6, 89, 6] -> 0

Console.WriteLine();
Console.WriteLine("Программа считает сумму элементов на нечётных индексах");
Console.WriteLine();
Console.WriteLine("Задайте длину массива (например, из 5 элементов)");

int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];

int sumOfOddElements = 0;
for(int i = 0; i < array.Length; i++)
{
    int randomNumber = new Random().Next(-100, 100);
    array[i] = randomNumber;

    Console.Write(array[i] + ", ");
}
for(int i = 1; i < array.Length; i += 2)
{
    sumOfOddElements += array[i];
}

Console.WriteLine();
Console.WriteLine("Сумма элементов на нечётных индексах равна = " + sumOfOddElements);
Console.WriteLine();