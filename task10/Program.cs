// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("введите трёхзначное число :");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = Math.Abs(num);
if ((num1 >= 999) || (num1 <= 99))
{
    Console.WriteLine("это не трёхзначное число !!!");
}
else
{
   Console.WriteLine($"второе число трёхзначного числа :{num1 / 10 % 10}"); 
}
