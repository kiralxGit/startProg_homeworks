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



Console.Write("Введите число b1: ");
double b1 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите число k1: ");
double k1 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите число b2: ");
double b2 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите число k2: ");
double k2 = Convert.ToDouble(Console.ReadLine()!);

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"({x}; {y})");