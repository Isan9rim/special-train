﻿/*Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
а = 25; b = 5 -> да
a = 2; b = 10 -> нет
а = 9; b = -3 -> да
a = -3; b = 9 -> нет
*/
System.Console.WriteLine("Введи первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введи второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 / number2 == number2 || number2 / number1 == number1)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}