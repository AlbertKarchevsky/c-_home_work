/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/
int[] EnteringNumbers(int arrayLength)
{
    int[] array = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        Console.WriteLine($"Введите поочерёдно нажимая Enter числа");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
int PositiveNumbers(int[] Array)
{
    int positiveNumbers = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > 0)
        {
            positiveNumbers = positiveNumbers + 1;
        }
    }
    return positiveNumbers;
}


Console.WriteLine("Сколько чисел будет введено?");
int length = Convert.ToInt32(Console.ReadLine());


int [] array = EnteringNumbers(length);
int positiveNumbers = PositiveNumbers(array);
Console.WriteLine ($"Количество положительных чисел: {positiveNumbers}");