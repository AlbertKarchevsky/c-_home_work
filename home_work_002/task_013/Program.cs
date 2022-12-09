// Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99)
{
    int m = 10;
    int buff = num;
    while (buff > 999)
    {
        buff = num / m;
        m = m * 10;
    }
    
    int answer = buff % 10;
    Console.WriteLine(answer);
}
else
{
    Console.WriteLine("В числе третьей цифры нет");
}