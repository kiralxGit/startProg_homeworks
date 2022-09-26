//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine()!);

PrintPow(a, b);

void PrintPow(int a, int b){
    Console.WriteLine(GetPow(a, b));
}

int GetPow(int a, int b){
    int sum = 1;
    for(; b > 0; b--){
        sum *= a;
    }
    return sum;
}


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("Сумма чисел: " + PrintSum(num));

int PrintSum(int num){
    int sum = 0;
    while(num > 0){
        sum += num % 10;
        num /= 10;
    }
    return sum;
}


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

/* Вариант 1: создаём массив из 8 эл-ов и выводим на первой строке первые 5, а на второй оставшиеся 3 эл-та */
PrintRndArr(8);
void PrintRndArr(int quantity){
    int[] array = new int[quantity]; // создаём массив заданной длины

    for(int i = 0; i < array.Length; i++){ // наполняем
        array[i] = new Random().Next(1, 34);
    }
    // форматирование и вывод
    Console.Write("[");
    for(int i = 0; i < 5; i++) {
        Console.Write(array[i]);
        if(i + 1 < 5)Console.Write(",");
    }
    Console.Write("]");
    Console.WriteLine();

    Console.Write("[");
    for(int i = 5; i < quantity; i++) {
        Console.Write(array[i]);
        if(i + 1 < quantity)Console.Write(",");
    }
    Console.Write("]");
    Console.WriteLine();
}

/* Вариант 2: как я ещё понял задание, то есть вбиваем строку, преобразуем её в строчный массив и выводим */
MakeAndPrintArray();
void MakeAndPrintArray(){
    string[] numbers = GetStringArray();
    PrintArray(numbers);
}
string[] GetStringArray(){
    Console.Write("Введите значения элементов массива через запятую или пробел: ");
    string inputString = Console.ReadLine()!; // получаем строку
    char[] separators = new char[]{' ', ','};
    //преобразуем в строковый массив элементов с разделителем separators и чисткой пустых строк
    string[] arrayString = inputString.Split(separators, StringSplitOptions.RemoveEmptyEntries); 
    return arrayString;
}
void PrintArray(string[] arr){
    Console.WriteLine("[" + String.Join(", ", arr) + "]");
}