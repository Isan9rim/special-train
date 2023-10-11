/* Напишите программу, которая вводит случайное число из отрезка (10,99) и 
показываее наибольшую цифру числа.
78 -> 8
12 -> 2
85 - > 8
*/


int number = new Random().Next(10, 100);
Console.WriteLine(number);

int first = number / 10;
int last = number % 10;

if (first > last)
{
   System.Console.WriteLine("первая больше"); 
}
else if (last > first)
{
    System.Console.WriteLine("вторая больше"); 
}
else
{
    System.Console.WriteLine("числа равны");
}