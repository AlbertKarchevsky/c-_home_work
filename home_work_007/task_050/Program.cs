/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
[0][1][2][3]
1 4 7 2
[4][5][6][7]
5 9 2 3
[8][9][10][11]
8 4 2 4

9 -> 4
5 -> 9
*/

double[,] TwoDArrayGen(int lengthOfColumns, int lengthOfStrings, double Min, double Max)
{
    double[,] twoDArray = new double[lengthOfStrings, lengthOfColumns];
    for (int i = 0; i < lengthOfStrings; i++)
    {
        for (int j = 0; j < lengthOfColumns; j++)
        {
            Random random = new Random();
            twoDArray[i, j] = random.NextDouble() * (Min - Max) + Min;
        }
    }
    return twoDArray;
}

void print2DArray(double[,] TwoDArray)
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
Console.WriteLine("Введите максимальное, значение в массиве");
double Max = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите минимальное значение в массиве");
double Min = Convert.ToDouble(Console.ReadLine());

double[,] Array2D = TwoDArrayGen(lengthOfColumns, lengthOfStrings, Min, Max);
print2DArray(Array2D);
Console.WriteLine("Введите первый индекс элемента  двумерного массива");
int firstIndex = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второй индекс элемента  двумерного массива");
int SecondIndex = Convert.ToInt32(Console.ReadLine());

if (SecondIndex + 1 > lengthOfColumns | firstIndex + 1 > lengthOfStrings)
{
    Console.WriteLine("В массиве нет элемента с таким индексом");
    return;
}
else
{
    double arrayValue = Array2D[firstIndex, SecondIndex];
    Console.WriteLine($"Значение элемента массива c индексом [{firstIndex}, {SecondIndex}] равно {arrayValue}");
}