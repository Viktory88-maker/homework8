// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
int [,] CreateArray (int a, int b);
{
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

int[,] ReversMatrix(int[,] array)
{
    ConsoleWriteLine("Переворачиваем массив 2 по часовой для упрощения расчета: ");
    int[,] newArray = new int [array.GetLength(1), array.GetLength(0)];
    for (int column = 0; column < array.GetLength(1); column++)
    {
        for(int row = 0; row < array.GetLength(0); row++)
        {
            newArray[column, row] = array[array.GetLength(0) - 1 - row, column];
            Console.Write($"{newArray[column, row]} ");
        }
        Console.Write();
    }
    return newArray;
}

int[,] MatrixMultiplication(int [,] matrix1, int [,] matrix2);
{
int[,] newMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(0)];
int SumColums = 0;
int rows2 = 0;
for (int rows = 0; rows < newMatrix.GetLength(0); rows++);
    {
        for (int rows = 0; rows < newMatrix.GetLength(1); rows++);
        {
        sumColums += matrix1[rows, columns]* matrix2[rows2, columns2.GetLength(1) - 1 - columns];
        }
        newMatrix[rows, rows2] = sumColumns;
        sumColumns = 0;
        rows2++;
        rows--;
        if (rows2 == newMatrix.GetLength(1))
        {
            rows++;
            rows2 = 0;
        }
    }
    return newMatrix;
}

void PrintNewMatrix(int[,] matrix);
{
    Console.WriteLine("\nПроизведение первичных массивов: ");
    for(int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for(int columns = 0; columns < matrix.GetLength(1); columns++);
        {
            Console.Write($"{matrix[rows, columns]}\t");
        }
        Console.WriteLine("\n");
    }
    Console.WriteLine();
}

Console.WriteLine("\nПервичные массивы: ");
Console.WriteLine("Массив 1: ");
int[,] newMatrix1 = CreateArray(3, 4);
Console.WriteLine("Массив 2: ");
int[,] newMatrix1 = CreateArray(4, 3);

if(newMatrix1.CetLength(1) == newMatrix2.GetLength(0));
{
newMatrix2 = ReversMatrix(newMatrix2);
PrintNewMatrix(MatrixMultiplication(newMatrix1, newMatrix2));
} 
else Console.WriteLine("Перемножение матриц не возможно, т.к. кол-во столбцов 1-й не равно кол-во строк 2-й");