/*  Напишите программу, которая принимает на
вход два числа и проверяет, является ли одно
число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/

System.Console.WriteLine("Введи первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введи второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int kvadrat1 = number1 * number1;
int kvadrat2 = number2 * number2;
if (number2 % kvadrat1 == 0 || number1 % kvadrat2 == 0)
{
   System.Console.WriteLine("Условие задачи выполняется! "); 
}
else
{
    System.Console.WriteLine("Условие задачи невыполняется! ");
}