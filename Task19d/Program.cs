// Напишите программу, принимающую на вход пятизначное число и проверяет,
// является ли оно палиндромом. (палиндром - число читается слева направо и
// справа налево одинаково)

// 14212 -> нет     12821 -> да     23432 -> да

// вариант 1 +
Console.WriteLine("Введите 5-значное число для проверки его на ПАЛИНДРОМ: ");
string str1 = Console.ReadLine();
int number = Convert.ToInt32(str1);

char[] n1 = number.ToString().ToCharArray();
char[] n2 = number.ToString().ToCharArray();
Array.Reverse(n2);

string s1 = new String(n1);
string s2 = new String(n2);

    if(s1 != s2)
    {
        Console.WriteLine("Число " + str1 + " НЕ является палиндромом.");
    }
    else
    {
        Console.WriteLine("Число " + str1 + " является палиндромом.");
    }
// ---------------------------

// вариант 2
// Console.WriteLine("Введите 5-значное число для проверки его на ПАЛИНДРОМ: ");
// string str1 = Console.ReadLine();
// for(int i = 0; i < str1.Length/2; i++)
//     if(str1[i] != str1[str1.Length - 1 - i])    {
//         Console.WriteLine("Число " + str1 + " НЕ является палиндромом.");
//     }
//     else {
//         Console.WriteLine("Число " + str1 + " является палиндромом.");
//     }
// ---------------------------------

// Console.WriteLine("Введите 5-значное число для проверки его на ПАЛИНДРОМ: ");
// string str1 = Console.ReadLine();
// int number = Convert.ToInt32(str1);

// char[] n1 = number.ToString().ToCharArray();
// char[] n2 = number.ToString().ToCharArray();
// Array.Reverse(n2);

// string s1 = new String(n1);
// string s2 = new String(n2);

//     if(s1 != s2)
//     {
//         Console.WriteLine("Число " + str1 + " НЕ является палиндромом.");
//     }
//     else
//     {
//         Console.WriteLine("Число " + str1 + " является палиндромом.");
//     }
// ---------------------------------

// int dig, temp;
// int sum = 0;

// int number = Convert.ToInt32(str1);
// temp = number;

// // while(number > 0)
// while(Convert.ToBoolean(number))
// {
//     dig = number % 10;
//     number = number / 10;
//     sum = sum * 10 + dig;
//     // temp = temp * 10 + dig;
// }    
// if (temp == number)
//     {
//         Console.WriteLine("Число " + number + " является палиндромом.");
//     }
// else 
//     {
//         Console.WriteLine("Число " + number + " НЕ является палиндромом.");
//     }

// string str2 = new StringBuilder();
// for (int i = str1.length - 1; i >= 0; --i)
// str2.append(str1.charAt(i));
// string str2 = str1.charAt(i);

//     Console.WriteLine(str2);

// if (str2.equals(str1.ToString))
// {
//     Console.WriteLine("Число " + str1 + " является палиндромом.");
// }

// else {
//     Console.WriteLine("Число " + str1 + " НЕ является палиндромом.");
// }