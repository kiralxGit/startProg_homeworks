// Задача 2:
// Напишите программу, которая на вход принимает два числа и
// выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

/*
Console.WriteLine("Введите первое целое число:");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе целое число:");
int num2 = int.Parse(Console.ReadLine()!);

if (num1 > num2) Console.WriteLine($"max = {num1}");
else if (num1 < num2) Console.WriteLine($"max = {num2}");
else Console.WriteLine("Вы ввели одинаковые числа или что-то пошло не так :(");
*/

/*---------------------------------------------------------------------------*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт
// максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
/*
Console.WriteLine("Введите первое целое число:");
int numb1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе целое число:");
int numb2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье целое число:");
int numb3 = int.Parse(Console.ReadLine()!);
int max = numb1;

if (max < numb2) max = numb2;
if (max < numb3) max = numb3;
Console.WriteLine(max);
*/

/*---------------------------------------------------------------------------*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
/*
Console.WriteLine("Введите целое число:");
int evenNumber = int.Parse(Console.ReadLine()!);

if (evenNumber % 2 == 0) Console.WriteLine("Да");
else Console.WriteLine("Нет");
*/
/*---------------------------------------------------------------------------*/

// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое число больше 1:");
int n = int.Parse(Console.ReadLine()!);
int i = 2;
while (i <= n)
{
   Console.Write(i + " ");
   i = i + 2; 
}