Console.WriteLine("Программа определит и выведет чётные числа от 1 до N");

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int a = 1; a < N; a++)
    if (a % 2 == 0)
        Console.Write(" " + a + " ");
Console.WriteLine();

Console.WriteLine("Спасибо!");