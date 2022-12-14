/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine ("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите показатель степени для числа");
int exponentNumber = Convert.ToInt32(Console.ReadLine());

int Exponent(int number, int exponentNumber)
{
    int exponent = 1;
    for (int i = 1; i <= exponentNumber; i++)
    {
        exponent = number*exponent;
    }
    return exponent;
}

int answer = Exponent(number, exponentNumber);
Console.WriteLine ($"{number}^{exponentNumber} = {answer}");
