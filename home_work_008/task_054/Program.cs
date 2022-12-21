/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

int[,] ArraySortMaxMin(int[,] d2Array)
{
    int[,] SortArrayMaxMin = d2Array;
    for (int i = 0; i < SortArrayMaxMin.GetLength(0); i++)
    {
        for (int j = 0; j < SortArrayMaxMin.GetLength(1); j++)
        {

            for (int b = j + 1; b < SortArrayMaxMin.GetLength(1); b++)
            {
                if (SortArrayMaxMin[i, j] < SortArrayMaxMin[i, b])
                {
                    int buff = SortArrayMaxMin[i, j];
                    SortArrayMaxMin[i, j] = SortArrayMaxMin[i, b];
                    SortArrayMaxMin[i, b] = buff;
                }
            }
        }
    }
    return SortArrayMaxMin;
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


Console.WriteLine("Введите число столбцов в массиве");
int lengthOfColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число строк в массиве");
int lengthOfStrings = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение в массиве");
int Max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение в массиве");
int Min = Convert.ToInt32(Console.ReadLine());


int[,] d2Array = ArrayGen(lengthOfStrings, lengthOfColumns, Min, Max);
Console.WriteLine("Вывод не отсортированного массива");
print2DArray(d2Array);
int[,] sortArrayMaxMin = ArraySortMaxMin(d2Array);
Console.WriteLine("\nВывод отсортированного массива");
print2DArray(sortArrayMaxMin);