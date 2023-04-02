
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

--------------------------------------- 
СЕМИНАР от 02.04.2023 

ЗАДАЧА - написать программу, которая показывает какой длины массив 


int number = int.Parse(Console.ReadLine());
Console.WriteLine(GetLengthNumber(number));

int[] ConvertToArray(int number)
{
    int length = GetLengthNumber(number); 
    int [] result = new int[length]; 

    for (int i = 0; i < length; i++)
    {
        result[i] = number * 10;
        number = number / 10;
    }
}

int GetLengthNumber(int number)
{
    int length = 0; 

    while (number != 0)
    {
        number = number / 10;
        length++;
    }
    return length;
}

ГОТОВО 

 

ЗАДАЧА - Напишите программу, которая принимает число А и выдает 
сумму числе от 1 до А. 

int a = int.Parse(Console.ReadLine());

int sum = GetSumToNumber(a);
Console.WriteLine(sum);

int GetSumToNumber(int number)
{
    int sum = 0;

    for (int i = 1; i < number; i++)
    {
        sum += i;
    }
    return sum;
}
----------------------- 
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 5 -> 120

ЗАДАЧА 28 
---------------- 

Console.WriteLine("Введите число и я покажу произведение от 1 до этого числа: ");
int a = int.Parse(Console.ReadLine()); 

int f = Factorial(a);
Console.WriteLine($"{a} -> {f}");

int Factorial(int a)
{
    int factorial = 1; 

    for (int i = 1; i <= a; i++)
    {
        factorial = factorial * i;
    }
    return factorial;
}
 
ЗАДАЧА 30: 
Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
_____________________________

Console.WriteLine("Введите длину массива");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = int.Parse(Console.ReadLine());

int[] array = RandomArray(size, min, max); 
PrintArray(array);
int[] RandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
        array[i] = rand.Next(min,max);
    
    return array;
} 
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

ДОМАШНЕЕ ЗАДАНИЕ 

*/ 
Console.WriteLine("Введите число A: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine());

int c = 1;
if (b<1)
Console.WriteLine("Число B должно быть натуральным\n");
else
{
while (b!=0)
{
c = c * a;
b = b — 1;
}
Console.Write($"Число A в натуральной степени B равно {c}");
}