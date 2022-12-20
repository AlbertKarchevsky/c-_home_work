/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

Console.WriteLine("Введите число столбцов в массиве");
int lengthOfColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число строк в массиве");
int lengthOfStrings = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное, значение в массиве");
double Max = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите минимальное значение в массиве");
double Min =  Convert.ToDouble(Console.ReadLine());

double[,] TwoDArrayGen(int lengthOfColumns, int lengthOfStrings, double Min, double Max)
{
    double[,] twoDArray = new double[lengthOfStrings, lengthOfColumns];
    for (int i = 0; i < lengthOfStrings; i++)
    {
        for (int j = 0; j < lengthOfColumns; j++)
        {
            Random random = new Random();
            twoDArray[i, j] = random.NextDouble() * (Max - Min) + Min;
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
}


double[,] Array2D = TwoDArrayGen(lengthOfColumns, lengthOfStrings, Min, Max);
print2DArray(Array2D);