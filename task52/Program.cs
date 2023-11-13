/* Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, PrintListAvr и FindAverageInColumns.
Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся на определенное число. Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.
Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.
Метод FindAverageInColumns принимает целочисленную матрицу типа int[,] и возвращает одномерный массив типа double. Этот метод вычисляет среднее значение чисел в каждом столбце матрицы и сохраняет результаты в виде списка.
Метод PrintListAvr принимает одномерный массив, возвращенный методом FindAverageInColumns и выводит этот список на экран в формате
The averages in columns are:
x.x0 x.x0 x.x0 ..., где x.x0 - это значения средних значений столбцов, округленные до двух знаков после запятой (в дробной части ВСЕГДА должно быть 2 числа через точку, см. формат вывода), разделенные знаком табуляции.

Пример

n = 3;
m = 4;
k = 2;

int[,] result = CreateIncreasingMatrix(n, m, k);
PrintArray(result);
PrintListAvr(FindAverageInColumns(result));

1   3   5   7   
9   11  13  15  
17  19  21  23  
The averages in columns are:
9.00    11.00   13.00   15.00
*/

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] Fibonacci(int number)
{
    int size = number;
    if (number < 2) size = 2;
    int[] array = new int[size];
    array[0] = 0;
    array[1] = 1;

    for (int i = 2; i < size; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void PrintArray(int[] arrayOne)
{
    System.Console.Write("Number N = " + arrayOne.Length + ": ");
    Console.ForegroundColor = ConsoleColor.Blue;
    for (int i = 0; i < arrayOne.Length; i++)
    {
        System.Console.Write(" " + arrayOne[i]);
    }
    System.Console.WriteLine();
}
int number = Prompt("Enter number: ");
PrintArray(Fibonacci(number));