// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными
//  вещественными числами от -10,0 до 10,0.
// m = 3, n = 4.

// 0,5 7,0 -2,0 -0,2
// 1,0 -3,3 8,0 -9,9
// 8,0 7,8 -7,1 9,0

// void FillArray (double[,] matr)
// {
// for (int i = 0; i < matr.GetLength(0);i++)
// {
//     for (int j = 0; j < matr.GetLength(1);j++)
//     {
//         double x = new Random().Next(-100,101);
//         matr[i,j] = Math.Round(x/10,1);
//     } 
// }
// }
// void PrintArray (double[,] matr)
// {
// for (int i = 0; i < matr.GetLength(0);i++)
// {
//     for (int j = 0; j < matr.GetLength(1);j++)
//     {
//         Console.Write($"{matr[i,j]} ");
//     }
//     Console.WriteLine();
// }
// }
// Console.WriteLine("Введите m");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите n");
// int n = int.Parse(Console.ReadLine());
// double [,] matrix = new double[m,n];
// FillArray(matrix);
// PrintArray(matrix);









// Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы числа
//  в двумерном массиве или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет


// Console.WriteLine("Введите число:");
// int m = int.Parse(Console.ReadLine());
// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 20);
//         }
//     }
// }
// void FindArray(int number, int[,] matr)
// {
//     bool x = false;
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {  
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (matr[i, j] == number) 
//             {
//                 Console.WriteLine($"{number} -> такое число в массиве есть: индекс ({i}, {j})");
//                 x = true;
//             }
//             else
//             {
//                 continue;
//             }
//         }
//     }
//     if (x == false) Console.WriteLine($"{number} -> такого числа в массиве нет");
// }
// int[,] matrix = new int[3, 4];
// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// FindArray(m, matrix);








// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(0, 10);
//         }
//     }
// }
// void SredArifmStolbcovArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(1); i++)
//     {
//         double x = 0;
//         double y = 0;
//         double z = 0;
//         for (int j = 0; j < matr.GetLength(0); j++)
//         {
//             x = x + matr[j, i];
//             z++;
//         }
//         y = Math.Round(x / z, 1);
//         Console.Write(y + " ");
//     }
// }
// int[,] matrix = new int[3, 4];
// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// SredArifmStolbcovArray(matrix);