/*Напишите программу которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
Если второе число некратно первому, то программа выводит остаток от деления.
34, 5 -> некратно, остаток 4
16, 4 -> кратно
*/

System.Console.WriteLine("Введи первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введи второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 % number1 == 0)
{
    System.Console.WriteLine($"Число {number1} кратное числу {number2}! ");
}
else
{
    int result = number2 % number1;
    System.Console.WriteLine($"Остатокт от деления: {result} ");
}
