﻿/*Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: 
Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3 
1 2 3 4
2 3 4 5
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


void PrintMatrix(int[,] arr)
{
    System.Console.Write("[ ] \t");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        System.Console.Write($"[{j}] \t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        System.Console.Write($"[{i}] \t");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
        Console.ForegroundColor = ConsoleColor.Cyan;
        System.Console.Write(" " + arr[ i, j] + "\t");
        Console.ResetColor();
        }
        System.Console.WriteLine();
    }
    Console.ResetColor();
}