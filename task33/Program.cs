/* Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да



int[] GetRnd(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Thread.Sleep(100);
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("]");
    Console.ResetColor();
}

bool Numb(int[] arr, int srav)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == srav) return true;
        if (arr[i] * -1 == srav) return true;
    }
    return false;
}
*/
int[] CreateArray(int size, int min, int max)
{
    var random = new Random();

    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(min, max);
    }
    return arr;
}

void Output(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

// void IsBelong(int[] arr, int number)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] == number)
//         System.Console.WriteLine($"Число {number} есть в массиве");
//         // else if(arr[i]!= number)
//         // System.Console.WriteLine($"Числа {number} нет в массиве");
//     }
// }

bool IsBelong(int[] arr, int number)
{
    bool result = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number)
            result = true;
    }
    return result;
}

int[] arr = CreateArray(4, -21, 10);
Output(arr);

System.Console.WriteLine("Введите число: ");

int n = int.Parse(Console.ReadLine());
// IsBelong(arr, n);

// System.Console.WriteLine(IsBelong(arr, n));
bool result2 = IsBelong(arr,n);
System.Console.WriteLine((result2)?$"Число {n} в массиве есть":"Числа {n} в массиве нет");
