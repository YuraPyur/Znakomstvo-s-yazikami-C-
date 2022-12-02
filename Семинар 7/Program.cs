// Задача 1: Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
// по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.

// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


// void FillArray (int[,] matr)
// {
// for (int i = 0; i < matr.GetLength(0);i++)
// {
//     for (int j = 0; j < matr.GetLength(1);j++)
//     {
//         matr[i,j] = i+j;
//     } 
// }
// }
// void PrintArray (int[,] matr)
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
// int [,] matrix = new int[m,n];
// FillArray(matrix);
// PrintArray(matrix);










// Задача 2: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
//  и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4


// void FillArray (int[,] matr)
// {
// for (int i = 0; i < matr.GetLength(0);i++)
// {
//     for (int j = 0; j < matr.GetLength(1);j++)
//     {
//         if (i%2==0 && j%2==0)
//         {
//             matr[i,j] = matr[i,j]*matr[i,j]; // есть команда, которая возводит в квадрат, но я ее не помню
//         }
//     } 
// }
// }
// void PrintArray (int[,] matr)
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
// int [,] matrix = new int[3,4]
// {
//     {1,4,7,2},
//     {5,9,2,3}, 
//     {8,4,2,4},
// };
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);