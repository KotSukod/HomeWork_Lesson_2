﻿ //Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
 int num = new Random().Next(100,1000);
Console.WriteLine("Наше число: " + num);

int a = num % 100;
Console.WriteLine($"Вторая цифра числа {num} - {a / 10}");
