/*Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, FindNumberByPosition и PrintCheckIfError.
Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся на определенное число. Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.
Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу. Элементы матрицы должны быть выведены через символ табуляции для более читаемого вывода.
Метод FindNumberByPosition принимает на вход сгенерированную матрицу и числа x и y - позиции элемента в матрице. Если указанные координаты находятся за пределами границ массива, метод должен вернуть массив с нулевым значением. Если координаты находятся в пределах границ, метод должен вернуть массив с двумя значениями: значением числа в указанной позиции, а второй элемент должен быть равен 0, чтобы показать, что операция прошла успешно без ошибок.
Метод PrintCheckIfError должен принимать результат метода FindNumberByPosition и числа x и y - позиции элемента в матрице. Метод должен проверить, был ли найден элемент в матрице по указанным координатам (x и y), используя результаты из метода FindNumberByPosition. Если такого элемента нет, вывести на экран "There is no such index". Если элемент есть, вывести на экран "The number in [{x}, {y}] is {значение}".
Пример
n = 3;
m = 4;
k = 2;
x = 8;
y = 3;
int[,] result = CreateIncreasingMatrix(n, m, k);
PrintArray(result);
PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);

1   3   5   7   
9   11  13  15  
17  19  21  23  
There is no such index

n = 4;
m = 5;
k = 3;
x = 2;
y = 2;

int[,] result = CreateIncreasingMatrix(n, m, k);
PrintArray(result);
PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);

1   4   7   10  13  
16  19  22  25  28  
31  34  37  40  43  
46  49  52  55  58  
The number in [2, 2] is 37
*/

int TakeEnteredNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] GetIndex2DArray(int row, int column, int k)
{
    int[,] array = new int[row, column];
    int num = 1;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = num;
            num = num + k;
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int userArrayRow = TakeEnteredNumber("Введите количестов строк:");
int userArrayColumn = TakeEnteredNumber("Введите количестов столбцов:");
int numberK = TakeEnteredNumber("What number to encrese? ");
int[,] user2DIndexArray = GetIndex2DArray(userArrayRow, userArrayColumn, numberK);

Print2DArray(user2DIndexArray);
int PositionX = TakeEnteredNumber("Which row to find: ");
int PositionY = TakeEnteredNumber("Which column to find: ");

void FindElemnetInArray(int[,] array, int x, int y)
{
    if(x < array.GetLength(0) && y < array.GetLength(1))
    System.Console.WriteLine($"Такое число в массиве есть, это число {array[x, y]}");
    else
    System.Console.WriteLine("Такого числа в массиве нет!");
}
FindElemnetInArray(user2DIndexArray, PositionX, PositionY);
