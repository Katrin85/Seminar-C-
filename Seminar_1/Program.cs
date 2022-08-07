Console.Clear();
/*
Console.Write("Прекрасно, введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int quad = num * num;
//Console.WriteLine("Твое число в квадрате = " + quad);
Console.WriteLine($"Твое число {num} в квадрате = {quad}");
*/
// Задача 2.

/*
Console.Write("Первая: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int quad2 = num2 * num2;
if (num1 == quad2)
{
    Console.WriteLine($"{num1} это квадрат {num2}");
}
else
{
    Console.WriteLine($"{num1} это не квадрат {num2}");
}
*/

// Задача 3. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int current = number * (-1);
while (current <= number)
{
    Console.Write(current + " ");
    current++;
}
*/

// Задача 4. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.Write("Введите 3-х зн.число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ed = number % 10;

Console.WriteLine($"Последняя цифра числа {number} равна = {ed}");