// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

// 3 -> Среда
// 5 -> Пятница

System.Console.WriteLine("Введи число: ");
int weekDay = Convert.ToInt32(Console.ReadLine());

int day1 = 1;
int day2 = 2;
int day3 = 3;
int day4 = 4;
int day5 = 5;
int day6 = 6;
int day7 = 7;

if (weekDay == day1) Console.WriteLine("понедельник ");
else if (weekDay == day2) Console.WriteLine("вторник ");
else if (weekDay == day3) Console.WriteLine("среда ");
else if (weekDay == day4) Console.WriteLine("четверг ");
else if (weekDay == day5) Console.WriteLine("пятница ");
else if (weekDay == day6) Console.WriteLine("суббота ");
else if (weekDay == day7) Console.WriteLine("воскресенье ");
else Console.WriteLine("Введено неверное число");