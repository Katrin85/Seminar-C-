/*
// Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
int FindSum (int number)
{
    int sum = 0; 
    for (int i = 1; i <= number; i++)
        sum = sum + i;            
    return sum;
}
Console.Write("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = FindSum(a);
Console.WriteLine($"Sum of numbers from 1 to {a} is {result}");
*/

/*
// Задача 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
int Count (int number)
{
    char[] arr = number.ToString().ToCharArray();
    int count = arr.Length;
    if (arr[0] == '-') count--;
    return count;
}
Console.Write("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = Count(a);
Console.WriteLine($"Tere are {result} digit in number {a}");
*/


/*
// Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
int FindComposition (int number)
{
    int comp = 1; 
    for (int i = 1; i <= number; i++)
        comp = comp * i;        // comp *= i    
    return comp;
}
Console.Write("Input integer number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = FindComposition(a);
Console.WriteLine($"composition of numbers from 1 to {a} is {result}");
*/

/*
// Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
int [] newArray = new int[size];
for (int i = 0; i < size; i++)
    newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
*/