// Задача 64: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//     N = 5 -> "5, 4, 3, 2, 1"
//     N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// Console.WriteLine("Задача 64:");
// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine(FromNto1(N));
// string FromNto1(int n)
// {
//     if (n == 1) return "1";
//     return n + " " + FromNto1(n - 1);
// }

// Console.WriteLine();
//----------------------------------------------------------------------------------------------
// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
//     M = 1; N = 15 -> 120
//     M = 4; N = 8. -> 30
Console.WriteLine("Задача 66:");
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(SumFromMtoN(m, n));
int SumFromMtoN(int m, int n)
{
    if (n == m) return m;
    return n + SumFromMtoN(m, n-1);
}

Console.WriteLine();
//----------------------------------------------------------------------------------------------
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
//     m = 2, n = 3 -> A(m,n) = 9
//     m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("Задача 68:");