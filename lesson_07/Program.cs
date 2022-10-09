// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 7 -2 -85
// 1 -3 8 -9
// 8 7 -7 9

PrintArray(GetArray(minValue: -99, maxValue: 99));

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// i = 4, j = 2 -> такого числа в массиве нет
// i = 1, j = 2 -> 2

Console.Write("Кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

Console.Write("Какой индекс строки ищем: ");
int rowsSearch = int.Parse(Console.ReadLine()!);
Console.Write("Какой индекс столбца ищем: ");
int columnsSearch = int.Parse(Console.ReadLine()!);

int [,] arr = GetArray(m: rows, n: columns);
PrintArray(arr);
Console.WriteLine(SearchIndex(rowsSearch, columnsSearch, arr));

string SearchIndex(int rows, int col, int[,] array)
{
    if((array.GetLength(0) > rows) && (array.GetLength(1) > col)) return Convert.ToString(array[rows, col]);
    else return "такого числа в массиве нет";
}


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] arr = GetArray();
PrintArray(arr);
//int[,] arr = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};

Console.WriteLine(String.Join("; ", SearchAverageColumns(arr)) + ".");
double[] SearchAverageColumns(int[,] array)
{
    double[] res = new double[array.GetLength(1)];
    for (int j = 0, sum = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        res[j] = Math.Round(Math.Floor(((double) sum / array.GetLength(0)) * 10) / 10, 1);
        sum = 0;
    }
    return res;
}







/* Общие методы */
int[,] GetArray(int m = 3, int n = 4, int minValue = 0, int maxValue = 9)
{
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}