/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.WriteLine("Введите целое число равное или больше 1");
int N = Convert.ToInt32(Console.ReadLine());

void Сube(int number)
{
    for (int i = 1; i <= number; i++)
    {
        double cube = Math.Pow (number - (number - i), 3);
        Console.Write ($"{cube}, ");
    }
}
Сube(N);