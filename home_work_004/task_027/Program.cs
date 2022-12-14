/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.WriteLine("Введите целое число");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int SumAllNumbers(int integerNumber)
{
    int sum = 0;
    int num = integerNumber;
    for (int n = 10; num != 0; n = n * 10)
    {
        sum = sum + (num % 10);
        num = integerNumber / n;
    }
    return sum;

}

int answer = SumAllNumbers(number);

Console.WriteLine($"Сумма цифр в числе {number} равна {answer}");
