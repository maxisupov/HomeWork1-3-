﻿//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int startNumber = 1;


while(startNumber <= N)
    {
        if(startNumber % 2 == 0)
        Console.Write(startNumber + " ");
        startNumber ++;
    }