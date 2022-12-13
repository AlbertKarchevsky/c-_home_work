/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine ("Введите координату X первой точки");
int A1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату Y первой точки");
int A2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату Z первой точки");
int A3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату X второй точки");
int B1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату Y второй точки");
int B2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координату Z второй точки");
int B3 = Convert.ToInt32(Console.ReadLine());


double LengthBetweenPoints(int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
double Length =  Math.Sqrt(Math.Pow(X2-X1, 2) + Math.Pow(Y2-Y1, 2) + Math.Pow (Z2-Z1, 2));
return Length;
}

double Length = LengthBetweenPoints(A1, A2, A3, B1, B2, B3);

Console.WriteLine ($"Расстояние между точками равно {Length}.");