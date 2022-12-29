﻿// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку
//с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер 
//строки с наименьшей суммой элементов: 1 строка

void CreateArrayAndFindMinRow(int a, int b);
{
    int minSum = a*b;
    int minSumRow = 0;
    int sum = 0;
    Console.WriteLine("\nПервичный массив:");
    int[,] matrix = new int[a, b];
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for(int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows, columns] = new Random().Next(1, 10);
            Console.Write($"{matrix[rows, columns]} ");
            sum += matrix[rows, columns];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minSumRow = rows;
        }
        sum = 0;
        Console.WriteLine();
    }
    Console.WriteLine($"\nИндекс строки с наименьшей суммой элементов ({minSum}) = {minSumRow}: ");
    Console.WriteLine();
}
CreateArrayAndFindMinRow(6, 4);

