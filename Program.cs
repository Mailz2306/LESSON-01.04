
/* 
Console.WriteLine("Введите число X");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число Y");
int y = int.Parse(Console.ReadLine());

int result = GetNumberofQuarter(x, y);
if (result == 0)
{
    Console.WriteLine("X и Y равны нулю. Данные введены не правильно");
    return;
}
Consple.WriteLine(result);

string Get (int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }

    if (y > 0 && x < 0) 
    {
        return 2;
    }

    if (y < 0 && x > 0)
    {
        return 3;
    }

    if (y > 0 && x < 0)
    {
        return 4; 
    }
}

-------------------------
Задача 21
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве.
A (3,6,); B (2,1,) -> 5.09
A (7,-5); B (1,-1) -> 

Console.WriteLine("Введите координату X первой точки: ");
int x1 = int.Parse(Console.ReadLine()); 

Console.WriteLine("Введите координату X первой точки: ");
int y1 = int.Parse(Console.ReadLine()); 

Console.WriteLine("Введите координату X второй точки: ");
int x2 = int.Parse(Console.ReadLine()); 

Console.WriteLine("Введите координату Y второй точки: ");
int y2 = int.Parse(Console.ReadLine()); 

int A = x2 - x1;
int B = y2 - y1;

double length = Math.Sqrt(A * A + B * B );
Console.WriteLine($"Длинна отрезка {length}");



-----------------------------
Задача 19


Задача 21
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
--------------------------------

ЗАДАЧА 19 
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да


Console.WriteLine("Введите число, которое нужно проверить: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} -> Да");
    }
    else
    {
        Console.WriteLine($"{number} -> Нет");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
}


-----------------------
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()); 

for (int i = 1; i <= N; i++)
{ 
    Console.Write($" {i*i} ");
}

