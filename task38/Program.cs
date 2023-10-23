/* Напишите программу для работы с массивом вещественных чисел. Реализуйте класс ArrayOperations, который содержит 
следующие статические методы: FindMax(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает 
максимальное число из массива. FindMin(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает 
минимальное число из массива. CalcDifferenceBetweenMaxMin(double[] array): Метод принимает на вход массив вещественных чисел 
array и возвращает разницу между максимальным и минимальным числами в массиве. PrintArray(double[] array): Метод для вывода 
массива на экран. Он принимает на вход массив array и выводит его элементы с двумя знаками после запятой через табуляцию.
Аргументы, передаваемые в метод/функцию:
'3.17, 8.94, 2.36, 5.72, 0.85'
На выходе:
Массив:
3.17    8.94    2.36    5.72    0.85    
Разность между максимальным и минимальным элементом = 8.09
*/

Console.Clear();

double[] GetDoubleRnd(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-99, 99) + new Random().NextDouble();
    }
    return array;
}

void PrintDoubleArray(double[] arr)
{
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Thread.Sleep(1);
        System.Console.Write(Math.Round(arr[i], 2));
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("]");
    Console.ResetColor();
}

double[] arrayDouble = GetDoubleRnd(5);
PrintDoubleArray(arrayDouble);
