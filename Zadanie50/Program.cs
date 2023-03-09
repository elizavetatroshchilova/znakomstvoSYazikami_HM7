// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] CreateArray() 
{
    int[,] array = new int[6, 6];
    return array;
}

int[,] FillArray(int[,] emptyArray) 
{
    for(int i = 0; i < emptyArray.GetLength(0); i++) 
    {
        for(int j = 0; j < emptyArray.GetLength(1); j++) 
        {
            emptyArray[i, j] = new Random().Next(0, 10); 
        }
    }

    return emptyArray;
}


void FindingAnElement(int[,] filledArray) {
    Console.Write("Введите номер строки: ");
    int line = int.Parse(Console.ReadLine()!);
    Console.WriteLine();

    Console.Write("Введите номер столбца: ");
    int column = int.Parse(Console.ReadLine()!);
    Console.WriteLine();

    if(line > filledArray.GetLength(0) || column > filledArray.GetLength(1)) Console.WriteLine("Такого элемента в массиве нет");
    else 
    {
        Console.WriteLine(filledArray[line-1, column-1]);
    }
}

FindingAnElement(FillArray(CreateArray()));