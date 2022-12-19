/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
double IntersectionPointX(int k1, int b1, int k2, int b2)
{
    double x = (double)(b2 - b1) / (k1 - k2);
    return x;
}

double IntersectionPointY(double x, int k1, int b1)
{
    double y = k1 * x + b1;
    return y;
}


Console.WriteLine("Введите значение k1 первой прямой");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b1 первой прямой");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2 второй прямой");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2 второй прямой");
int b2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
    return;
}

double x = IntersectionPointX(k1, b1, k2, b2);
double y = IntersectionPointY(x, k1, b1);
Console.WriteLine($"Прямые пересекаются в точке ({x}; {y})");