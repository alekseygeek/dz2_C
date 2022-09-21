// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
//Console.Clear();
Console.WriteLine(" введите  число");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = Math.Abs(num);
if (num1 < 100 )
{
    Console.WriteLine("третьего числа нет ! ");
}
if (num1 <= 999 && num1 >= 100)
{
    Console.WriteLine(num1 % 10);
}
if (num1 > 999)
{
    while(num1 > 999)
    {
        num1 = num1 / 10;
        if(num1 <= 999) 
        {
            Console.WriteLine(num1 % 10);
        }

    }
}


