// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateArray()
{
    int[,] array = new int[3, 5];
    return array;
}

int[,] FillArray(int[,] emptyArray) 
{
    for(int i = 0; i < emptyArray.GetLength(0); i++) 
    {
        for(int j = 0; j < emptyArray.GetLength(1); j++) 
        {
            emptyArray[i, j] = new Random().Next(1, 10); 
        }
    }

    for(int i = 0; i < emptyArray.GetLength(0); i++) 
    {
        for(int j = 0; j < emptyArray.GetLength(1); j++) 
        {
            Console.Write(emptyArray[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return emptyArray;
}

void Average(int[,] filledArray) 
{
    for(int j = 0; j < filledArray.GetLength(1); j++)
    {
        double average = 0;
        for(int i = 0; i < filledArray.GetLength(0); i++) 
        {
            average += filledArray[i,j];
        }
        average /= filledArray.GetLength(0);
        
        Console.Write($"{Math.Round(average, 1)}; ");
    }
}

Average(FillArray(CreateArray()));