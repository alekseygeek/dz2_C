// test
//Console.Write("число");
//int age = Convert.ToInt32(Console.ReadLine());
Console.Clear();
//int[] array = { 23, 34, 45, 56, 6, 7, 23, 9, 67};
//
//int n = array.Length;
//int find = 1;
//
//int index = 0;
// 
//while (index < n)
//{
//    if(array[index] == find)
//   {
//        Console.WriteLine(index);
//        break;
//    }
//    index++;
// } 

//int[] array = new int[10;]

// 17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка

// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает 
// диапазон возможных координат точек в этой четверти (x и y).

// Console.WriteLine("введите четверть ");
// int a = int.Parse(Console.ReadLine());
// if(a == 1)
// {
//     Console.WriteLine("x > 0 , y > 0");
// }
// else if(a == 2)
// {
//     Console.WriteLine("x < 0 , y > 0");
// }
// else if(a == 3)
// {
//     Console.WriteLine("x < 0 , y < 0");
// }
// else if(a == 4)
// {
//     Console.WriteLine("x > 0 , y < 0");
// } else{
//     Console.WriteLine("не верная четверть");
// }
// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

// Console.WriteLine("Введите x1: ");
// int x1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите y1: ");
// int y1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите x2: ");
// int x2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите y2: ");
// int y2 = int.Parse(Console.ReadLine());

// double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 -  y1, 2));

// Console.WriteLine($"Расстояние равно {Math.Round(r, 2)}");


// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.WriteLine("Введите число: ");
// int N = int.Parse(Console.ReadLine());
// int i = 1;

// while(i <= N)
// {
//     Console.WriteLine(Math.Pow(i, 2));
//     i++ ;
// }


// Задача 19
// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("введите пятизначное число :");
// int num = Convert.ToInt32(Console.ReadLine());

// if ((num >= 99999) || (num <= 9999))
// {
//     Console.WriteLine("это не пятизначное число !!!");
// }
// else if(num 10 % 10 *)
// {
//    Console.WriteLine("полиндром :"); 
// }
// else
// {
//     Console.WriteLine("не полиндром :");
// }


//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

  	
// Console.Write("введите пятизначное число: ");
// int num,r,sum=0,t;
// num = Convert.ToInt32(Console.ReadLine());
// for(t=num;num!=0;num=num/10){
//      r=num % 10;
//      sum=sum*10+r;
// }
// if(t==sum)
//      Console.Write("это число является полиндромом");
// else
//     Console.Write("это число не является полиндромом");

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// Console.Write("введите координату X первой точки: ");
// int x = int.Parse(Console.ReadLine());
// Console.Write("введите координату Y первой точки: ");
// int y = int.Parse(Console.ReadLine());
// Console.Write("введите координату Z первой точки: ");
// int z = int.Parse(Console.ReadLine());
// Console.Write("введите координату X второй точки: ");
// int x1 = int.Parse(Console.ReadLine());
// Console.Write("введите координату Y второй точки: ");
// int y1 = int.Parse(Console.ReadLine());
// Console.Write("введите координату Z второй точки: ");
// int z1 = int.Parse(Console.ReadLine());

// int A = x - x1;
// int B = y - y1;
// int C = z - z1;

// double length = Math.Sqrt(A * A + B * B + C * C);
// length = Math.Round(length, 2);
// Console.WriteLine($"длинна отрезка {length}");

//Задача 23 Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.


Console.Write(" введите число : ");
int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
     Console.WriteLine($"{i * i * i} ");
}