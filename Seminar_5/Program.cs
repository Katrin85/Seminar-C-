/*
// Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
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
void FindMinMaxSum(int[] array)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            sumPositive += array[i];
        else
            sumNegative += array[i];
    }
    Console.WriteLine("Sum of negatives elements is " + sumNegative);
    Console.WriteLine("Sum of positives elements is " + sumPositive);
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
FindMinMaxSum(myArray);
*/

/*
// Задача 2. Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
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
int[] ChangeElements(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = array[i] * (-1);
    }
    return array;
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
ShowArray(ChangeElements(myArray));
*/

/*
// Задача 3. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
int[] CreateArray(int size)
{
    int [] newArray = new int[size];
    for (int i = 0; i < size; i++)
        {
        Console.Write($"Input {i} element of the array: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());    
        }
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
bool CheckNumber(int[] array, int n)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == n) return true; // return if (array[i] == n) 
    }
    return false;
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer number: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray (a);
ShowArray(myArray);
bool check = CheckNumber(myArray, number);
if (check == true) Console.WriteLine($"Число {number} найдено в заданном массиве");
else Console.WriteLine($"Число {number} не найдено в заданном массиве");
*/
 

/*
// Задача 4. Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
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
int CountElements(int[] array, int min, int max)
{
    int count = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i]<= max) count++;
    }
   return count;
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value: ");
int max1 = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
int result = CountElements(myArray, min1, max1);
Console.WriteLine($"Количество элементов массива, находящихся в заданном отрезке, равно {result}");
*/


/*
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
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
int[] CompositionPairsOfElements(int[] array)
{
    int[] newArray = new int [array.Length / 2];
    for (int i = 0; i < array.Length / 2; i++)
    {
        newArray[i] = array[i]*array[array.Length - 1 - i];
    }
   return newArray;
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
ShowArray(CompositionPairsOfElements(myArray));
*/



// Задача №4. Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

