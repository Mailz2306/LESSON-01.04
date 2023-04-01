
/* 

ДОМАШНЕЕ ЗАДАНИЕ от 01.04.2023 

Задача 19: Напишите программу, которая принимает на вход пятизначное число и 
проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
------------
РЕШЕНИЕ 
------------------- 

Console.WriteLine("Введите число и я проверю, является ли он палиндромом: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} -> Да, это  палиндром");
    }
    else
    {
        Console.WriteLine($"{number} -> Нет, это не палиндром");
    }
}
else
{
    Console.WriteLine($"Это число {number} не пятизначное.");
}

---------------------------------------
 
Задача 21: Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

РЕШЕНИЕ:
-------------------

Console.WriteLine("Задайте координату X1 первой точки: ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Задайте координату Y1 первой точки: ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Задайте координату Z1 первой точки: ");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Задайте координату X2 второй точки: ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Задайте координату Y2 второй точки: ");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Задайте координату Z2 второй точки: ");
int z2 = int.Parse(Console.ReadLine());

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Расстояние между точками в 3D пространстве составляет -> {length}");

------------------------

Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

РЕШЕНИЕ 
--------------------
*/

int number = ReadInt("Введите число и я выдам перечень кубов от 1 до этого числа: ");

for (int i = 1; i <= number; i++)
{ 
    Console.Write($" {i*i*i} ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}