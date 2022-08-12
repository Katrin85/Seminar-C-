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














