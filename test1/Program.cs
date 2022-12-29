// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
int [,] CreateArray (int a, int b);
{
    Console.WriteLine("\nПервичный массив:");
    int[,] matrix = new int [a, b];
    for (int rows = 0, rows < matrix.CetLength(0); rows++)
    {
       for(int columns = 0; columns < matrix.GetLength(1); columns++)
       {
        matrix[rows, columns] = new Random().Next(1, 10);
        Console.WriteLine($"{matrix[rows, columns]} ");
       }
    Console.WriteLine();
    }
    Console.WriteLine();
    return matrix;
}

int[,] SortedRowsArray(int[,] array);
{
    int row = 0;
    int[] singleArray = new int [array.GetLength(1)];
    while (row < array.GetLength(0))
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        singleArray[columns] = array[row, columns];

        Array.Sort(singleArray);
        Array.Reverse(singleArray);

        for(int columns = 0; columns < array.GetLength(1); columns++)
        array[row, columns] = singleArray[columns];

        row++;
    }
    return array;
}

void PrintNewArray(int[,] matrix)
{
    Console.WriteLine("\nМассив после сортировки строк:");
    for(int rows = 0; rows < matrix.GetLength(0); rows++);
    {
        for(int columns = 0; columns; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($"{matrix[rows, columns]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

PrintnewArray(
    SortedRowsArray(
        CreateArray));

 