/*
// Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
void ShowNumbers(int n)
{
    if(n > 1) ShowNumbers(n-1);
    
    Console.Write(n + " ");
}
ShowNumbers(10);
*/

/*
// Задача 2.Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
int FindSum(int n)
{
    if(n > 0)
        return FindSum(n /10) + n % 10;
    else
        return n;
}
Console.WriteLine(FindSum(12345));
*/

/*
// Задача 3. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
void Metod(int n, int m)
{
    if(m != n)
    {
    if (n > m) 
        {
            Metod (n - 1, m);
            Console.Write(n + " ");
        }
    else
        {
            Metod(n, m - 1);
            Console.Write(m + " ");
        }
    
    } 
    else
    Console.Write(m + " ");
}
Metod(5, 9);
*/

/*
// Задача 4. Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
int NumberPower(int a, int b)
{
    if(b != 0)
    {
        return NumberPower(a, b - 1) * a;
    }
    else return 1;
}
Console.WriteLine(NumberPower(2,3));
*/