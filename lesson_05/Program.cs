// Все массивы от 5-ти элементов
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.WriteLine();
Console.WriteLine("Задача 34");

int[] numbers = GetArray(10, 100, 999);
Console.WriteLine('[' + String.Join(",", numbers) + ']');
Console.WriteLine("Чётных чисел: " + GetEvenQty(numbers));

int GetEvenQty(int[] array){
    int count = 0;
    foreach (var i in array){

        if ((i % 2) == 0) count++;
    }
    return count;
}

Console.WriteLine();
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.WriteLine("Задача 36");

int[] numbers36 = GetArray(10, -100, 100);
Console.WriteLine('[' + String.Join(",", numbers36) + ']');
Console.WriteLine("Сумма: " + GetOddIndexTotal(numbers36));

int GetOddIndexTotal(int[] array){
    int total = 0;
    for (int i = 1; i < array.Length; i += 2){
        total += array[i];
    }
    return total;
}


Console.WriteLine();
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.WriteLine("Задача 38");

double[] numbers38 = GetRealArray(10, -10, 10);
Console.WriteLine('[' + String.Join(", ", numbers38) + ']');
Console.WriteLine("Разница между макс и мин элементами: " + GetDiff(numbers38));

double[] GetRealArray(int size, int minValue, int maxValue){
    double[] res = new double[size];
    for (int i = 0; i < size; i++){
        res[i] = 0.0 + new Random().Next(minValue, maxValue + 1);
        res[i] += new Random().NextDouble();
        res[i] = Math.Round(res[i], 2);
    }
    return res;
}

double GetDiff(double[] array){
    int max = 0, min = 0;
    if (array[0] > array[1]) min = 1;
    else max = 1;
    for (int i = 2; i < array.Length; i++){
        if(array[i] > array[max]) max = i;
        else if(array[i] < array[min]) min = i;
    }   
    return (array[max] - array[min]);
}



/* --------------------- общие методы -------------------------- */

int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}