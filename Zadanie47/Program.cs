// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateArray(int line, int column)
{
    double[,] array = new double[line, column];
    return array;
}

double[,] FillArray(double[,] emptyArray) 
{
    for(int i = 0; i < emptyArray.GetLength(0); i++)
    {
        for(int j = 0; j < emptyArray.GetLength(1); j++) 
        {
            emptyArray[i, j] = Convert.ToDouble(new Random().Next(-10, 10)) / 2 ; 
        }
    }
    return emptyArray;
}

void PrintArray(double[,] filledArray) 
{
    for(int i = 0; i < filledArray.GetLength(0); i++)
    {
        
        for(int j = 0; j < filledArray.GetLength(1); j++)
        {
            Console.Write($"{filledArray[i,j]}  ");
        }
        Console.WriteLine();
    }
}



Console.Write("Введите количество строк : ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine();

Console.Write("Введите количество стоблцов : ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine();

PrintArray(FillArray(CreateArray(m, n)));