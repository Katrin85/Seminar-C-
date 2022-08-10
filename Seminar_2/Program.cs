/*
// задача №1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
int MaxNumber (int number)
{
    int ed = number % 10;
    int dec = number / 10;
    int max;
    if (ed > dec)
    {
         max = ed;
         return ed;
         
    }
    else
    {
        max = dec;
    }
    return max;
}

int randomNumber = new Random().Next(10, 100);
int bigNumber = MaxNumber(randomNumber);
Console.WriteLine($"Biggest digit of {randomNumber} is {bigNumber}");
*/
/*
// Задача №2. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int CutNumber (int number)
{
    int ed = number % 10;
    int sot = number / 100;
    int result = sot * 10 + ed;
    return result;
    // или return sot * 10 + ed;
}
int randomNumber = new Random().Next(100, 1000);
int newNumber = CutNumber(randomNumber);
Console.WriteLine("Трехзначное число: " + randomNumber);
Console.WriteLine("Новая версия" + newNumber);
*/
/*
// Задача №3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.
void IsKratno (int numA, int numB) 
{
    if (numB % numA == 0)
    Console.WriteLine(numB + "is IsKratno of" + numB % numA);
}
Console.WriteLine("Введиите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());
IsKratno(numA, numB);
*/

// Задача№4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
bool IsDivis (int number)
{
    if (number % 7 == 0 && number % 23 ==0)
        return true;
    else 
        return false;
}
Console.WriteLine("Input number: ");
int numbeer = Convert.ToInt32(Console.ReadLine());
bool isDivision = IsDivis(numbeer);
Console.WriteLine(isDivision);
