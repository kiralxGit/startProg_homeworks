// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

/* ---------- через string(массив) и условия, только для 5-ти значных ---------- */
Console.WriteLine("Введите 5-ти значное число: ");
int number = Convert.ToInt32(Console.ReadLine()!);
if ((number / 10000) == (number % 10)){
    if (((number / 1000) % 10) == ((number / 10 )% 10)) Console.WriteLine("да");
}else{
    Console.WriteLine("нет");
}

/* --------------- через string(массив) и цикл от 2-х значных--------------- */
Console.Write("Является ли палиндромом число: ");
string number = Console.ReadLine()!;
int len = number.Length;
for(int i = 0; i < (len / 2);i++){
    if (number[i] != number[len - i - 1]){
        Console.Write("нет");
        break;
    } else if (i + 1 == (len / 2)){
        Console.Write("да");
    }
}

/* --------------- через string(массив) и рекурсию от 1 значных --------------- */
Console.Write("Является ли палиндромом число: ");
string number = Console.ReadLine()!;

static Boolean IsPalindrom (string str, int i = 0){
    int len = str.Length - 1 - i;
    if ((str[i] == str[len]) && ((len - i) > 2)) return IsPalindrom(str, i + 1);
    else if (str[i] == str[len]) return true;
    else return false;
}
Console.WriteLine(IsPalindrom(number) ? "Да" : "Нет");


/*-------------------------------------------------------------------------------*/
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите x, y, z точки A через запятую: ");
string inA = Console.ReadLine()!;
string[] pointA = inA.Split(',');
double[] xyzA = new double [pointA.Length];
for (int i = 0; i < pointA.Length; i++){
    xyzA[i] = Convert.ToDouble(pointA[i]);
}
Console.WriteLine("Введите x, y, z точки B через запятую: ");
string inB = Console.ReadLine()!;
string[] pointB = inB.Split(',');
double[] xyzB = new double [pointB.Length];
for (int i = 0; i < pointB.Length; i++){
    xyzB[i] = Convert.ToDouble(pointB[i]);
}
double temp = Math.Sqrt(Math.Pow((xyzB[0] - xyzA[0]), 2) + Math.Pow((xyzB[1] - xyzA[1]), 2) + Math.Pow((xyzB[2] - xyzA[2]), 2));
Console.WriteLine($"{temp:f2}");

/*---------------------------------------------------------------------------------*/
// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine()!);
for(int i = 1; i <= n; i++) {
    Console.Write(Math.Pow(i, 3));
    if (i < n) Console.Write(", ");
}