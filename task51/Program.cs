/*Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
*/

int[,] Get2DArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i,j] = i+j;
        }
    } 
    return array;
}

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] user2DArray = Get2DArray(5,8);
Print2DArray(user2DArray);
/*
int FindSum(int[,] arr1)
{
    int sum = 0;
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            if(i == j) sum = sum + arr1[i,j];
        }
    }
    return sum;
}


int SumOfDiagonal(int [,] array)
{
    int result = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        result += array[i,i];        
    }

    return result;
}
*/