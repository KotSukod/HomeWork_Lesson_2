// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите числовое обозначение дня недели(от 1 до 7): ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 7)  Console.WriteLine("Введенное число больше 7");   
else if (a == 7) Console.WriteLine("Это выходной");
else if (a == 6) Console.WriteLine("Это выходной");
else Console.WriteLine("Это будней день");
