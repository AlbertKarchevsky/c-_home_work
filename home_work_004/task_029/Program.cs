/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
Console.WriteLine("Создание массива целых чисел из 8 элементов");
int[] ArrayGen()
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
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

}
int[] array = ArrayGen();
PrintArray(array);
