// Все массивы от 5-ти элементов
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0




// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76