﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое чило: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе чило: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе чило: ");
int c = int.Parse(Console.ReadLine());

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);
