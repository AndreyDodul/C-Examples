// Задайте массив, заполненный случайными положительными трёхзначными числами
// (длина массива 5 элементов). Напишите программу, которая покажет количество
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Программа заполнения массива случайными 3-значными числами");
Console.WriteLine("и нахождение чётных чисел");

Console.WriteLine("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine()); // задаем длину массива
int[] array = new int[arraySize];   // можно указать вместо [arraySize] длину массива
 // int[] array = new int[5];        // например, как здесь 5, т.е. [5]

int oddElements = 0;
int evenElements = 0;
for(int i = 0; i < array.Length; i++)
{
    int randomNumber = new Random().Next(-999, 999);
    array[i] = randomNumber;
    Console.Write(array[i] + ", ");
}
Console.WriteLine();

for(int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {   
        evenElements = evenElements;
        evenElements++;
    }
    else
    {   
        oddElements = oddElements;
        oddElements++;
    }
}

Console.WriteLine("Количество чётных элементов в массиве:    " + evenElements);
Console.WriteLine("Количество нечётных элементов в массиве:  " + oddElements);