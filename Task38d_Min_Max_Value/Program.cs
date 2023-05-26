// Задайте массив вещественных чисел от -100 до 100 (длина массива 5 элементов).
// Найдите разницу между максимальным и минимальным элементов массива.
//  [3 7 22 2 78] -> 76

Console.WriteLine();
Console.WriteLine("Программа считает разницу между максимальным и минимальным элементами");
Console.WriteLine();
Console.WriteLine("Задайте длину массива (например, из 5 элементов)");

int arraySize = Convert.ToInt32(Console.ReadLine());
double[] array = new double[arraySize];

for(int i = 0; i < array.Length; i++)
{
    double randomNumber = new Random().Next(-100, 100) + new Random().NextDouble();
    array[i] = Math.Round(randomNumber, 2);

    Console.Write(array[i] + ", ");
}
double min = 0;
double max = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] < min)
    {
        min = array[i];
    }
    if(array[i] > max)
    {
        max = array[i];
    }
}

Console.WriteLine();
Console.WriteLine("Разница между максимальным и минимальным значениями массива = " + (max - min));
Console.WriteLine();