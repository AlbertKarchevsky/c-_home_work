/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
Console.WriteLine("Введите число столбцов в массиве");
int lengthOfColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число строк в массиве");
int lengthOfStrings = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное, значение в массиве");
int Max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение в массиве");
int Min = Convert.ToInt32(Console.ReadLine());

int[,] TwoDArrayGen(int lengthOfColumns, int lengthOfStrings, int Min, int Max)
{
    int[,] twoDArray = new int[lengthOfStrings, lengthOfColumns];
    for (int i = 0; i < lengthOfStrings; i++)
    {
        for (int j = 0; j < lengthOfColumns; j++)
        {
            twoDArray[i, j] = new Random().Next(Min, Max + 1);
        }
    }
    return twoDArray;
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


double[] ArithmeticMean(int[,] TwoDArray)
{
    double[] arithmeticMeanArr = new double[TwoDArray.GetLength(1)];
    for (int j = 0; j < TwoDArray.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < TwoDArray.GetLength(0); i++)
        {
            sum = sum + TwoDArray[i, j];
        }
        arithmeticMeanArr[j] = (double)sum / TwoDArray.GetLength(0);
    }
    return arithmeticMeanArr;
}


void PrintArray(double[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]}, ");
    }
    Console.WriteLine();
}
int[,] TwoDArray = TwoDArrayGen(lengthOfColumns, lengthOfStrings, Min, Max);
print2DArray(TwoDArray);
double[] arithmeticMeanArr = ArithmeticMean(TwoDArray);
Console.WriteLine("Среднее арифметическое каждого столбца");
PrintArray(arithmeticMeanArr);