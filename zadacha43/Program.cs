// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void LineIntersection(double b1, double k1, double b2, double k2)
{
    if (k1 == k2) Console.WriteLine("Прямые не пересекаются");
    else
    {
        double x = (b1 - b2) / (k2 - k1);
        double y = (k2 * b1 - k1 * b2) / (k2 - k1);
        Console.WriteLine("(" + x + ";" + y + ")");
    }
}

Console.Write("Введите координату b первой прямой: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату k первой прямой: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату b второй прямой: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату k второй прямой: ");
double k2 = Convert.ToDouble(Console.ReadLine());
LineIntersection(b1, k1, b2, k2);