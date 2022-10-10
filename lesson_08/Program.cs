// Отсортировать нечетные столбцы массива по возрастанию.
// Вывести массив изначальный и массив с отсортированными нечетными столбцами
// Console.WriteLine("**Задача X:**");
// int [,] arrX = GetArray(m: 5, n: 5);
// PrintArray(arrX);
// Console.WriteLine();
// PrintArray(SortedOddRows(arrX));

// int[,] SortedOddRows(int[,] array)
// {
//     for (int i = 1; i < array.GetLength(0); i += 2)
//     {
//         for (int k = 0; k < array.GetLength(1); k++)
//         {
//             for (int j = k + 1, temp = 0; j < array.GetLength(1); j++)
//             {
//                 if (array[i,k] > array[i,j])
//                 {
//                     temp = array[i,k];
//                     array[i,k] = array[i,j];
//                     array[i,j] = temp;
//                 }; 
//             }
//         }
//     }
//     return array;
// }


// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.WriteLine("**Задача 54:**");
int [,] arr54 = GetArray();
PrintArray(arr54);
Console.WriteLine();
PrintArray(SortedRows(arr54));

int[,] SortedRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            for (int j = k + 1, temp = 0; j < array.GetLength(1); j++)
            {
                if (array[i,k] < array[i,j])
                {
                    temp = array[i,k];
                    array[i,k] = array[i,j];
                    array[i,j] = temp;
                }; 
            }
        }
    }
    return array;
}



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт
// номер строки с наименьшей суммой элементов: 1 строка

// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07







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