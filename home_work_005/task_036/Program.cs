/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/
Console.WriteLine("Введите количество элементов в массиве");
int arrayLength = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение в массиве");
int arrayMaxValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение в массиве");
int arrayMinValue = Convert.ToInt32(Console.ReadLine());

int[] arrayGen(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] Array)
{
    Console.WriteLine("Вывод созданного массива");
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]}, ");
    }
Console.WriteLine();
}

int SumOfOddPositions(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

int[] array = arrayGen(arrayLength, arrayMinValue, arrayMaxValue);
PrintArray(array);
int sum = SumOfOddPositions(array);
Console.WriteLine($"Сумма элементов массива с нечётными индексами равна {sum}");