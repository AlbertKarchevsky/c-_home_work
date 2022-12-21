/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] MultMatrix(int[,] FirstMatrix, int[,] SecondMatrix)
{
    int[,] MatrixResultOfMult = new int[FirstMatrix.GetLength(0), SecondMatrix.GetLength(1)];
    for (int i = 0; i < MatrixResultOfMult.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixResultOfMult.GetLength(1); j++)
        {
            int sum = 0;
            for (int r = 0; r < FirstMatrix.GetLength(1); r++)
            {
                sum = sum + FirstMatrix[i, r] * SecondMatrix[r, j];
                MatrixResultOfMult[i, j] = sum;
            }

        }
    }
    return MatrixResultOfMult;
}


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


Console.WriteLine("Введите количество колонок первой матрицы");
int ColumnsNumbersOfMatrixOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк первой матрицы");
int StringsNumbersOfMatrixOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента первой матрицы");
int MaxOfMatrixOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента первой матрицы");
int minOfMatrixOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество колонок второй матрицы");
int ColumnsNumbersOfMatrixTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк второй матрицы");
int StringsNumbersOfMatrixTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента второй матрицы");
int MaxOfMatrixTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента второй матрицы");
int minOfMatrixTwo = Convert.ToInt32(Console.ReadLine());

if (ColumnsNumbersOfMatrixOne != StringsNumbersOfMatrixTwo)
{
    Console.WriteLine("Умножение матриц невозможно");
    return;
}

int[,] MatrixOne = ArrayGen(StringsNumbersOfMatrixOne, ColumnsNumbersOfMatrixOne, minOfMatrixOne, MaxOfMatrixOne);
Console.WriteLine("Вывод первой матрицы");
print2DArray(MatrixOne);
int[,] MatrixTwo = ArrayGen(StringsNumbersOfMatrixTwo, ColumnsNumbersOfMatrixTwo, minOfMatrixTwo, MaxOfMatrixTwo);
Console.WriteLine("Вывод второй матрицы");
print2DArray(MatrixTwo);
int[,] MatrixMult = MultMatrix(MatrixOne, MatrixTwo);
Console.WriteLine("Вывод матрицы, полученной при умножении двух матриц");
print2DArray(MatrixMult);