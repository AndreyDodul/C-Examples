// Напишите программу, которая задаёт массив из 8 элементов (от -10 до 10) и
// выводит их на экран.
// 1, 2, 5, 7, 9 -> [1, 2, 5, 7, 9]             6, 1, 3 -> [6, 1, 3]

Console.WriteLine("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine()); // по задаче 8
int[] array = new int[arraySize];

for (int i = 0; i < array.Length; i++) // заполнение массива
{
    int randomNumber = new Random().Next(-10, 10); // генератор случайных чисел
    array[i] = randomNumber; // помещение случайного числа в массив на место с индексом i

    Console.Write(array[i] + ", "); // вывод в консоль результата - массива
}