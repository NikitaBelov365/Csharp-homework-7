// Задача 2: Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

int InputSize(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] ArrayCreation(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

bool IsExist(int[,] array, int row, int column)
{
    if (row >= 0 && row < array.GetLength(0) && column >= 0 && column < array.GetLength(1)) return true;
    else return false;
}

void Resulter(int[,] array, int row, int column, bool isExist)
{
    if (isExist) System.Console.WriteLine($"Value in array with row {row} and column {column} is {array[row, column]}");
    else System.Console.WriteLine($"Value in array with row {row} and column {column} is not in this array");
}

int rows = InputSize("Input ammount of rows");
int columns = InputSize("Input ammount of columns");
int[,] array = ArrayCreation(rows, columns);
int row = InputSize("Input row");
int column = InputSize("Input column");
PrintArray(array);
bool isExist = IsExist(array, row, column);
Resulter(array, row, column, isExist);