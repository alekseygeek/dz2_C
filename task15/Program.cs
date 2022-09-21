// Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.

Console.Write("введите цифру обозначающую день недели :");
int day = Convert.ToInt32(Console.ReadLine());
if(day < 1 || day > 7)
{
    Console.WriteLine(" не верно");
}
else if (day == 6 || day == 7)
{
    Console.WriteLine(" выходной ");
}
else 
{
    Console.WriteLine(" будни ");
}
