/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
Console.WriteLine("Введите количество элементов в массиве");
int arrayLength = Convert.ToInt32(Console.ReadLine());

int[] arrayGen(int Length)
{
    int[] array = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int NumberOfEven(int[] array)
{
    int amount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            amount++;
        }

    }
    return amount;
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

int[] array = arrayGen(arrayLength);
PrintArray(array);
int amount = NumberOfEven(array);


Console.WriteLine($"Количество чётных элементов в массиве равно {amount}");