/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

int[,] arr = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

for (int i = 0; i < arr.GetLength(0); i++)
{
    int[] row = Enumerable.Range(0, arr.GetLength(1))
                      .Select(x => arr[i, x])
                      .OrderByDescending(x => x)
                      .ToArray();

    for (int j = 0; j < row.Length; j++)
    {
        arr[i, j] = row[j];
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}




Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] arr = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };

int minRow = 0;
int minSum = int.MaxValue;

for (int i = 0; i < arr.GetLength(0); i++)
{
    int rowSum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        rowSum += arr[i, j];
        }
            if (rowSum < minSum)
        {
            minSum = rowSum;
            minRow = i;
        }
    }
Console.WriteLine("Row " + minRow + " has the smallest sum of " + minSum);



Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

int[,] matrix1 = { { 2, 4 }, { 3, 2 } };
int[,] matrix2 = { { 3, 4 }, { 3, 3 } };

int rows1 = matrix1.GetLength(0);
int cols1 = matrix1.GetLength(1);
int rows2 = matrix2.GetLength(0);
int cols2 = matrix2.GetLength(1);

if (cols1 != rows2)
    {
    Console.WriteLine("Ошибка: количество столбцов в первой матрице должно быть равно количеству строк во второй матрице.");
    return;
    }

int[,] result = new int[rows1, cols2];

for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < cols2; j++)
    {
        for (int k = 0; k < cols1; k++)
        {
            result[i, j] += matrix1[i, k] * matrix2[k, j];
        }
    }
}

for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < cols2; j++)
    {
        Console.Write(result[i, j] + " ");
    }
    Console.WriteLine();
}




Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

int[,,] array = new int[2,2,2];
var random = new Random();

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        for (int k = 0; k < 2; k++)
        {
            int num;
            do
            {
                num = random.Next(10, 100);
            }
            while (array.Cast<int>().Contains(num));
            array[i, j, k] = num;
        }
    }    
}

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        for (int k = 0; k < 2; k++)
        {
            Console.Write(array[i, j, k] + "(" + i + "," + j + "," + k + ") ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}




Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07


int[,] array = new int[4, 4];

int counter = 1;
int startRow = 0, endRow = array.GetLength(0) - 1;
int startCol = 0, endCol = array.GetLength(1) - 1;

while (counter <= array.Length)
{
    
    for (int i = startCol; i <= endCol; i++)
    {
    array[startRow, i] = counter++;
    }
    startRow++;

    for (int i = startRow; i <= endRow; i++)
    {
        array[i, endCol] = counter++;
    }
    endCol--;

    for (int i = endCol; i >= startCol; i--)
    {
        array[endRow, i] = counter++;
    }
    endRow--;

    for (int i = endRow; i >= startRow; i--)
    {
        array[i, startCol] = counter++;
    }
    startCol++;
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

*/