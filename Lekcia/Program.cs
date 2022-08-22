// string[,] table = new string[2,5];
// table[1,2] = "слово";
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }


// void PrintArray(int[,] matr)  // создаем двумерный массив
// {
//   for (int i = 0; i < 3; i++) // i < matr.GetLenght(0)
//   {
//     for (int j = 0; j < 4; j++) // j < matr.GetLenght(1)
//     {
//         Console.Write($"{matr[i, j]} ");
//     }
//     Console.WriteLine();
//   }
// }

// void FillArray(int[,] matr)  // заполняем массив случайными числами
// {
//     for (int i = 0; i < 3; i++)
//     {
//        for (int j = 0; j < 4; j++)
//        {
//         matr[i, j] = new Random().Next(1, 10);
//        }
//     }
// }

// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// Console.WriteLine();
// FillArray(matrix);
// PrintArray(matrix); 


// int[,] = new int[23, 25];
// 0 - закрашенный пиксель
// 1 - незакрашенный пиксель

// int[,] pic = new int[,]

// {
//     {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
//     {0,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
//     {0,1,0,0,0,0,0,0,0,0,0,0,0,1,0},
//     {0,1,0,0,0,0,0,0,0,0,0,0,0,1,0},
//     {0,1,0,0,0,0,0,0,0,0,0,0,0,1,0},
//     {0,1,0,0,0,0,0,0,0,0,0,0,0,1,0},
//     {0,1,0,0,0,0,0,0,0,0,0,0,0,1,0},
//     {0,1,0,0,0,0,0,0,0,0,0,0,0,1,0},
//     {0,1,0,0,0,0,0,0,0,0,0,0,0,1,0},
//     {0,1,0,0,0,0,0,0,0,0,0,0,0,1,0},
//     {0,1,0,0,0,0,0,0,0,0,0,0,0,1,0},
//     {0,1,0,0,0,0,0,0,0,0,0,0,0,1,0},
//     {0,1,0,0,0,0,0,0,0,0,0,0,0,1,0},
//     {0,1,1,1,1,1,1,1,1,1,1,1,1,1,0},
//     {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,},
// };
// void PrintImage(int[,] image) 
// {
//   for (int i = 0; i < 15; i++) 
//   {
//     for (int j = 0; j < 15; j++) 
//     {
//        // Console.Write($"{matr[i, j]} ");
//        if (image[i,j] == 0) Console.Write($" ");
//        else Console.Write($"+");
//     }
//     Console.WriteLine();
//   }
// }
// void FillImage(int row, int col) // закрашиваем рисунок
// {
//  if (pic[row, col] == 0) // если позиция не закрашена
//  {
//     pic[row, col] = 1;  // тогда закрашиваем
//     FillImage(row-1, col);
//     FillImage(row, col-1);
//     FillImage(row+1, col);
//     FillImage(row, col+1);
//  }
// }

// PrintImage(pic);
// FillImage(3, 3);
// PrintImage(pic);


// Вычисление факториала 5!= 5*4*3*2*1
                      //     5*4!
                      //       4*3!
                      //         3*2!

// double Factorial (int n)
// {
//    if (n == 1) return 1; // 1! = 1
//    else return n * Factorial(n-1);
// }
// for (int i = 1; i < 40; i++)
// {
//           // Console.WriteLine(Factorial(3));     // 1*2*3=6
//     Console.WriteLine($"{i} = {Factorial(i)}");
// }

// фибоначи
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)
double Fibonacci(int n)
{
    if(n == 1 || n ==2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(Fibonacci(i));
}