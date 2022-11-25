// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int firstNumber = int.Parse (Console.ReadLine());
int secondNumber = int.Parse (Console.ReadLine());
int thirdNumber = int.Parse (Console.ReadLine());
int max = firstNumber;
if (secondNumber > firstNumber)
{
    max = secondNumber;
}
if (thirdNumber > secondNumber)
{
    max = thirdNumber;
}
Console.WriteLine(max);

