// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через запятую: ");
string numbers = Console.ReadLine()!;
string[] arr = numbers.Split(',');
int[] arrNums = new int [arr.Length];
int count = 0;
for (int i = 0; i < arr.Length; i++){
    arrNums[i] = Convert.ToInt32(arr[i]);
    if (arrNums[i] > 0) count++;
}
Console.WriteLine(count);


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double[,] resArr= new [2, 2];

Console.Write("Введите число b1: ");
resArr[0, 0] = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите число k1: ");
resArr[0, 1] = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите число b2: ");
resArr[1, 0] = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите число k2: ");
resArr[1, 1] = Convert.ToInt32(Console.ReadLine()!);


Console.WriteLine();