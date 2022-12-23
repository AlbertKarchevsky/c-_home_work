/* Задача 66. Задайте значения M и N. Напишите программу, которая найдёт
 сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int NaturalSum(int M, int N)
{
    int sum = 0;
    for (int i = 0; (N - i) >= M; i++)
    {
        sum = sum + (N - i);
    }
    return sum;
}


Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

int sum = NaturalSum(M, N);
Console.WriteLine($"Сумма натуральных элементов между M = {M} и N = {N} равна {sum}");