// Отсортировать нечетные столбцы массива по возрастанию.
// Вывести массив изначальный и массив с отсортированными нечетными столбцами

// Console.WriteLine("Задача с семинара:");
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

//----------------------------------------------------------------------------------------------
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

// Console.WriteLine("Задача 54:");
// int [,] arr54 = GetArray();
// PrintArray(arr54);
// Console.WriteLine();
// PrintArray(SortedRows(arr54));
// int[,] SortedRows(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int k = 0; k < array.GetLength(1); k++)
//         {
//             for (int j = k + 1, temp = 0; j < array.GetLength(1); j++)
//             {
//                 if (array[i,k] < array[i,j])
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

//----------------------------------------------------------------------------------------------
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // 5 2 6 7
    // Программа считает сумму элементов в каждой строке и выдаёт
    // номер строки с наименьшей суммой элементов: 1 строка
// Console.WriteLine("Задача 56:");
// int [,] arr56 = GetArray(m: 4, n: 4);
// PrintArray(arr56);
// Console.WriteLine();
// FindMinString(arr56);
// void FindMinString(int[,] array)
// {
//     int idMinString = 0,
//         sumMin = 0,
//         sumString = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {  
//         for (int k = 0; k < array.GetLength(1); k++)
//         {
//             sumString += array[i, k];
//         }
//         //Console.WriteLine("Строка id: " + i + " сумма эл-ов: " + sumString);
//         if (i == 0) sumMin = sumString;
//         if (sumString < sumMin)
//         {
//             sumMin = sumString;
//             idMinString = i;
//         }
//         sumString = 0;
//     }
//     Console.WriteLine("Cтрока с наименьшей суммой элементов: " + (idMinString + 1));
// }

//----------------------------------------------------------------------------------------------
// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
    // Например, даны 2 матрицы:
    // 2 4 | 3 4
    // 3 2 | 3 3
    // Результирующая матрица будет:
    // 18 20
    // 15 18
// Console.WriteLine("Задача 58:");
// int [,] arr581 = GetArray(m: 2, n: 2);
// //int[,] arr581 = new int[,]{{2,4}, {3,2}}; // проверка 1
// //int[,] arr581 = new int[,]{{2,4}, {3,2}}; // проверка 2
// //int[,] arr581 = new int[,]{{2,4}, {3,2}, {2,5}}; // проверка 3

// PrintArray(arr581);
// Console.WriteLine();
// int [,] arr582 = GetArray(m: 2, n: 2);
// //int[,] arr582 = new int[,]{{3,4}, {3,3}}; // проверка 1
// //int[,] arr582 = new int[,]{{3,4,1}, {3,3,4}}; // проверка 2
// //int[,] arr582 = new int[,]{{3,4,2}, {3,3,1}}; // проверка 3

// PrintArray(arr582);
// Console.WriteLine();
// if(arr581.GetLength(0) == arr582.GetLength(1)) PrintArray(MultiplyArray(arr581,arr582));
// else Console.WriteLine("Кол-во строк первой матрицы не равно кол-ву столбцов второй");

// int[,] MultiplyArray(int[,] array1, int[,] array2)
// {
//     int[,] res = new int[array1.GetLength(0), array2.GetLength(1)];
//     for (int i = 0; i < array1.GetLength(0); i++)
//     {
//         for (int k = 0, sum = 0; k < array2.GetLength(1); k++)
//         {   
//             for (int r1 = 0, c2 = 0; c2 < array2.GetLength(0); r1++, c2++)
//             {
//                 sum += array1[i, r1] * array2[c2, k];
//             }
//             res[i,k] = sum;
//             sum = 0;
//         }
//     }
//     return res;
// }

//----------------------------------------------------------------------------------------------
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
    // Массив размером 2 x 2 x 2
    // 66(0,0,0) 25(0,1,0)
    // 34(1,0,0) 41(1,1,0)
    // 27(0,0,1) 90(0,1,1)
    // 26(1,0,1) 55(1,1,1)
// Console.WriteLine("Задача 60:");
// //int[,,] arr60 = new int[,,]{{{66,27},{25,90}},{{34,26},{41,55}}};
// //PrintArray3d(arr60);
// PrintArray3d(GetArray3dDiffElements());
// int[,,] GetArray3dDiffElements(int m = 2, int n = 2, int o = 2, int minValue = 10, int maxValue = 99){
//     int[] arrayDiffEl= GetArrayDiffElements(m*n*o, minValue, maxValue);
//     int count = 0;
//     int[,,] res = new int[m, n, o];
//     for (int i = 0; i < m; i++)
//     {
//         for (int k = 0; k < n; k++)
//         {
//             for (int l = 0; l < o; l++)
//             {
//                 res[i,k,l] = arrayDiffEl[count];
//                 count++;
//             }
//         }
//     }
//     return res;
// }

// int[] GetArrayDiffElements(int length, int minValue, int maxValue){
//     int[] res = new int[length];
//     int r;
//     for (int i = 0; i < length; i++)
//     {  
//         r = new Random().Next(minValue, maxValue + 1);
//         for (int k = 0; k < i;)
//         {
//             if (r == res[k]) {
//                 r = new Random().Next(minValue, maxValue + 1);
//                 k = 0;
//             }
//             else k++;
//         }
//         res[i] = r;
//     }
//     return res;
// }

// void PrintArray3d(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int k = 0; k < array.GetLength(1); k++)
//         {
//             for (int l = 0; l < array.GetLength(2); l++)
//             {
//                 Console.Write($"{array[k,l,i]}({k},{l},{i}) ");
//             }
//         Console.WriteLine();
//         }
//     }
// }


//----------------------------------------------------------------------------------------------
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
Console.WriteLine("Задача 62:");
//int[,] arr62 = new int[4,4]{{01,02,03,04},{12,13,14,05},{11,16,15,06},{10,09,08,07}};
PrintArray2Digitals(GetSpiralArray());

int[,] GetSpiralArray(int size = 4)
{
    int[,] res = new int[size,size];
    int maxElement = size * size;
    int i = 1,
        x = -1,
        y = 0,
        dx = 1,
        dy = 0;
    while (i <= maxElement)
    {
        if ((x + dx < size && x + dx >= 0) && (y + dy < size && y + dy >= 0) && (res[(y + dy), (x + dx)] == 0))
        {
                x += dx;
                y += dy;
                res[y, x] = i;
        }
        else
        {
            if (dx == 1)
            {
                dx = 0;
                dy = 1;
                i--;
            }
            else if (dy == 1)
            {
                dx = -1;
                dy = 0;
                i--;
            }
            else if (dx == -1)
            {
                dx = 0;
                dy = -1;
                i--;
            }
            else if (dy == -1)
            {
                dx = 1;
                dy = 0;
                i--;
            }

        }
        i++;
    }
    return res;
}

void PrintArray2Digitals(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0:D2}", array[i, j]) + " ");
        }
        Console.WriteLine();
    }
}




/* --------------------------- Общие методы --------------------------- */

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

