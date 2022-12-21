/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] ArrayGen(int lengthOfStrings, int lengthOfColumns, int minValue, int maxValue)
{
    int[,] d2Array = new int[lengthOfStrings, lengthOfColumns];
    for (int i = 0; i < lengthOfStrings; i++)
    {
        for (int j = 0; j < lengthOfColumns; j++)
        {
            d2Array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return d2Array;
}

int[] SumStringsD2Array(int[,] d2Array)
{
    int[] sumStringsD2Array = new int[d2Array.GetLength(0)];
    for (int i = 0; i < d2Array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < d2Array.GetLength(1); j++)
        {
            sum = sum + d2Array[i, j];
            sumStringsD2Array[i] = sum;

        }
    }
    return sumStringsD2Array;
}

int MinOfString(int[] array)
{
    int Min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (Min > array[i])
        {
            Min = array[i];
        }
    }
    return Min;
}

int IndexOfMin(int[] array, int minArrayValue)
{
    int indexOfMin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == minArrayValue)
        {
            indexOfMin = i;
            return indexOfMin;
        }
    }
    return indexOfMin;
}

void print2DArray(int[,] TwoDArray)
{
    for (int i = 0; i < TwoDArray.GetLength(0); i++)
    {
        Console.WriteLine();

        for (int j = 0; j < TwoDArray.GetLength(1); j++)
        {
            Console.Write(TwoDArray[i, j] + "\t");
        }

    }
    Console.WriteLine();
}

void PrintArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]}, ");
    }
    Console.WriteLine();
}



Console.WriteLine("Введите число столбцов в массиве");
int lengthOfColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число строк в массиве");
int lengthOfStrings = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение в массиве");
int Max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение в массиве");
int Min = Convert.ToInt32(Console.ReadLine());


int[,] d2Array = ArrayGen(lengthOfStrings, lengthOfColumns, Min, Max);
Console.WriteLine("Вывод  массива");
print2DArray(d2Array);
int[] sumStringsD2Array = SumStringsD2Array(d2Array);
Console.WriteLine("Вывод массива, где каждый элемент является суммой элементов строки двумерного массива.\nИндекс элемента массива совпадает с индексом строки двумерного массива");
PrintArray(sumStringsD2Array);
int minArrayValue = MinOfString(sumStringsD2Array);
int IndexOfMinimum = IndexOfMin(sumStringsD2Array, minArrayValue);
Console.WriteLine($"Номер строки двумерного массива с наименьшей суммой  {IndexOfMinimum + 1}");