//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 100) Console.WriteLine("В данном числе нет третей цифры");
//int b = a;

int TheThirdNum (int number)
{
    while (number >= 1000)
    {
        number = number / 10;
    }
int third = number % 10;
return third;
}

 Console.WriteLine($"Третья цифра числа {a} - {TheThirdNum(a)}");




