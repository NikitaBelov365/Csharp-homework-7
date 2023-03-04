// Задача 1: Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

int InputSize(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] ArrayCreation(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rnd.NextDouble() * (10 - (-10)) + (-10), 2);
        }
    }
    return array;
}

void PrintArray(double[,] array)
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

int rows = InputSize("Input rows in new array");
int columns = InputSize("Input columns in new array");
double[,] array = ArrayCreation(rows, columns);
PrintArray(array);
