// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine(" введите трёхзначное число");
int num = int.Parse(Console.ReadLine()!);

if (num < 100)
{
    Console.WriteLine("третьего числа нет ! ");
}
else
{
    num = num % 10 ;
    Console.WriteLine($"третья цифра = {num}");
}
