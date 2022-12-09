// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int second = num % 100;
second = second / 10;
Console.WriteLine(second);
