// Задача 3: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int InputSize(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] ArrayCreation(int row, int column)
{
    int[,] array = new int[row, column];
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

void ArithmeticalMean(int[,] array)
{
    
    for (int j = 0; j < array.GetLength(0); j++)
        {      
        int sum = 0;  
        int average = 0;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            sum += array[i,j];
        }
        average = sum/array.GetLength(1);
        System.Console.WriteLine($"Average in {j+1} column is {average}");

    }
}

int rows = InputSize("Input ammount of rows in new array");
int columns = InputSize("Input ammount of columns in new array");
int[,] array = ArrayCreation(rows, columns);
PrintArray(array);
ArithmeticalMean(array);