// Задача 1: Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

int InputSize(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] ArrayCreation(int m, int n)
{
    double[,] array = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Math.Round(rnd.NextDouble()*(10-0)+0,2);
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
    }
    System.Console.WriteLine();
}

PrintArray(ArrayCreation(InputSize("Input m"), InputSize("Input n"))); // проверил можно ли положить функцию в функцию в функцию. Можно)