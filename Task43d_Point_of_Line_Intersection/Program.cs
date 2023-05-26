// Программа, вычисляющая точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    // Формулы нахождения координат x и y точки пересечения:
    // x = (b2-b1)/(k1-k2);
    // y = k1*x+b1;

    // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Вариант 1
// Console.WriteLine("Программа вычисления координат X и Y точки пересечения 2-х прямых");
// Console.Write("Введите коэффициенты функций: b1, k1, b2, k2: ");

// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Значение b1: " + b1);
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Значение k1 = " + k1);
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Значение b2 = " + b2);
// double k2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Значение k2 = " + k2);

// double x = (b2 - b1) / (k1 - k2);
// double y = k1 * x + b1;

// Console.WriteLine("Координаты точки пересечения прямых: Х и Y - " + (x, y));


// Вариант 2 (эталонное)
const int Coefficient = 0;
const int Constant = 1;
const int X_coordinate = 0;
const int Y_coordinate = 1;
const int Line1 = 1;
const int Line2 = 2;

double[] lineData1 = InputLineData(Line1);
double[] lineData2 = InputLineData(Line2);

if(ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    Console.WriteLine($"Точка пересечения уравнений y={lineData1[Coefficient]}*x + {lineData1[Constant]} и y={lineData2[Coefficient]}*x + {lineData2[Constant]}");
    Console.WriteLine($"имеет координаты ({coord[X_coordinate]}, {coord[Y_coordinate]})");
}

// ввод числа
double Prompt(string message)
{
    Console.WriteLine(message);     // вывести сообщение
    string value = Console.ReadLine(); // считывает с консоли строку
    double result = Convert.ToDouble(value); // преобразует строку в целое число
    return result;      // выводит результат
}

// ввод данных по прямой
double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[Coefficient] = Prompt("Введите коэффициент k для " + numberOfLine + " прямой > ");
    lineData[Constant] = Prompt("Введите константу b для " + numberOfLine + " прямой > ");
    return lineData;
}

// поиск координат
double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    // coord[X_coordinate] = (lineData1[Constant] - lineData2[Constant]) / (lineData2[Coefficient]) - lineData1[Coefficient];
    // coord[Y_coordinate] = lineData1[Coefficient] * coord[X_coordinate] + lineData1[Constant];
    coord[X_coordinate] = (lineData2[Constant] - lineData1[Constant]) / (lineData1[Coefficient] - lineData2[Coefficient]);
    coord[Y_coordinate] = lineData1[Coefficient] * coord[X_coordinate] + lineData1[Constant];
    return coord;
}

bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if(lineData1[Coefficient] == lineData2[Coefficient])
    {
        if(lineData1[Constant] == lineData2[Constant])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}