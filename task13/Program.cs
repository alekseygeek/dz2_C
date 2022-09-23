// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
// Console.Write(" введите  число :");
// int num = Convert.ToInt32(Console.ReadLine());
// int num1 = Math.Abs(num);
// if (num1 < 100 )
// {
//     Console.WriteLine("третьего числа нет ! ");
// }
// if (num1 <= 999 && num1 >= 100)
// {
//     Console.WriteLine(num1 % 10);
// }
// if (num1 > 999)
// {
//     while(num1 > 999)
//     {
//         num1 = num1 / 10;
//         if(num1 <= 999) 
//         {
//             Console.WriteLine(num1 % 10);
//         }

//     }
// }
Console.Write("введите число :");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);
if (num > 99)
{
    while(num > 999)
    {
    num /= 10;
    }
    Console.WriteLine("третья цифра  :" + num%10);
}
else
{
    Console.WriteLine("не третьего числа");
}