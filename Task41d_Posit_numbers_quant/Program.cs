// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0
// ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2         1, -7, 567, 89, 223-> 3


// вариант 1
// Console.WriteLine("Программа определяет количество положительных чисел,");
// Console.WriteLine("из введённых пользователем с клавиатуры.");
// Console.WriteLine();

// Console.Write("Укажите количество вводимых чисел: ");
// int arraySize = Convert.ToInt32(Console.ReadLine());  //задаём длину массива
// int[] array = new int[arraySize];   // можно указать вместо [arraySize] длину массива
//  // int[] array = new int[4];        // например, 4, т.е. [4]

// for(int i = 0; i < array.Length; i++)
// {
//     // int randomNumber = new Random().Next(-999, 999); // ввод случайных чисел
//     // array[i] = randomNumber;
        
//     int userNumber = Convert.ToInt32(Console.ReadLine()); // ввод с консоли чисел
//     array[i] = userNumber;
// }

// Console.Write("Введённые числа:   ");
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + ", ");
// }

// int countOfPositiveNumber = 0;
// for(int i = 0; i < array.Length; i++)
// {
//     if(array[i] > 0)
//     countOfPositiveNumber++;
// }
// Console.WriteLine();
// Console.WriteLine("Количество положительных чисел: " + countOfPositiveNumber);


// вариант 2

Console.WriteLine("Программа определяет количество положительных чисел,");
Console.WriteLine("из введённых пользователем c клавиатуры.");
Console.WriteLine();

int Prompt(string message)                  // считать данные с консоли
{
    Console.WriteLine(message);      // вывести сообщение
    string number = Console.ReadLine();     // считывает с консоли строку
    int quantity = Convert.ToInt32(number); // преобразует строку в целое число
    return quantity;
}

// ввести массив
int[] InputArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < array.Length; i++)
        {
        array[i] = Prompt($"Введите {i + 1}-й элемент");
        }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
    Console.WriteLine($"a[{i}] = {array[i]}");
    }
}

int CountOfPositiveNumber(int[] array)
{
    int countOfPositiveNumber = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            countOfPositiveNumber++;
        }
    }
    return countOfPositiveNumber;
}

int length = Prompt("Введите количество элементов > ");
int[] array;
array = InputArray(length);
PrintArray(array);
Console.WriteLine($"Количество положительных чисел:  + {CountOfPositiveNumber(array)}");