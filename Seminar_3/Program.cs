//№1 Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
// void DiapCoordin (int qart)
// {
//     if (qart == 1) 
//         Console.WriteLine("Диапазон возможных значений: X - положителен, У - положителен");
//     if (qart == 2)
//         Console.WriteLine("Диапазон возможных значений: X - отрицателен, У - положителен");
//     if (qart == 3)
//        Console.WriteLine("Диапазон возможных значений: X - отрицателен, У - отрицателен");
//     if (qart == 4)
//        Console.WriteLine("Диапазон возможных значений: X - положителен, У - отрицателен");
//      if (qart < 1 || qart > 4)
//        Console.WriteLine("тАККОЙ ЧЕТВЕРТИ НЕ СУЩествует");
// }

// Console.WriteLine("Введите четверть");
// int q = Convert.ToInt32 (Console.ReadLine());
// DiapCoordin (q);






//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// double Length(double X1, double Y1, double X2, double Y2)
// {
//     double len1 = Math.Sqrt(Math.Pow(X2-X1,2) + Math.Pow(Y2-Y1,2));
//     return len1;
// }

// Console.WriteLine("Программа для определения длины отрезка на плоскости по 2-м координатам");

// Console.Write ("Введите координату Х точки А ");
// double xA = Convert.ToInt32 (Console.ReadLine());

// Console.Write ("Введите координату У точки А ");
// double yA = Convert.ToInt32 (Console.ReadLine());

// Console.Write ("Введите координату Х точки В ");
// double xB = Convert.ToInt32 (Console.ReadLine());

// Console.Write ("Введите координату У точки В ");
// double yB = Convert.ToInt32 (Console.ReadLine());

// double len = Length(xA, yA, xB, yB);
// Console.WriteLine("Длина отрезка равна " + len);


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.





// Напишите программу, которая принимает на вход число (N) и выдаёт на консоль квадраты чисел от 1 до N.
/*
Console.WriteLine("Напишите программу, которая принимает на вход число (N) и выдаёт на консоль квадраты чисел от 1 до N.");
void QardN(int n)
{
    for (int i = 1; i <= n; i++)
    {
        System.Console.Write(i*i + " ");
    }
}
Console.Write ("Введите натуральное число: ");
int num = Convert.ToInt32 (Console.ReadLine());
Console.Write("Квадраты  чисел от 1 до " + num + " равно: ");
QardN(num);
*/

// 2 вариант

//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)
/*
void FindCooardinats (int quarter)
{
   if(quarter == 1) 
   Console.WriteLine("Диапазон (х+, y+)");
   if(qquarter == 2)
   Console.WriteLine("Диапазон (х-, y+)");
   if(quarter == 3)
   Console.WriteLine("Диапазон (х-, y-)");
   if(quarter == 4)
   Console.WriteLine("Диапазон (х+, y-)");
}
Console.Write("Input number of quarter: ");
int quarter = Convert.ToInt32(Console.ReadLine());
FindCooardinats(quarter);
*/
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

/*
double FindDistance (double x1, double y1, double x2, double y2)
{
   return Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2)); 
  
}
Console.Write("Input x1: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double yb = Convert.ToDouble(Console.ReadLine());
double coordinate = FindDistance(xa, xb, ya, yb);
Console.WriteLine($"Distance is {coordinate}");
*/
//Задача №4. Напишите программу, которая принимает на вход число (N) и выдаёт на консоль квадраты чисел от 1 до N.

void ShowSquare (int n)
{
    int current = 1;
    while(current <= n)
    {
        Console.WriteLine($"Квадрат числа {current} = {current * current}");
        current++;
    }

}
Console.Write("Введите любое целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowSquare(number);













