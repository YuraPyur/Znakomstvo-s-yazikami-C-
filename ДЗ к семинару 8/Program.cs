// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int [,] matrix = new int[3,4];

// for (int i = 0; i < matrix.GetLength(0);i++)
// {
//     for (int j = 0; j < matrix.GetLength(1);j++)
//     {
//        matrix[i,j] = new Random().Next(0,11);
//     }
// }
// void UporyadElemArray (int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0);i++)
//     {
//        for (int j = 0; j < matr.GetLength(1); j++)
//        {
//                 for (int m = j+1; m <matr.GetLength(1); m++)
//                 {
//                     if (matr[i,j] < matr[i,m])
//                     {
//                         int t = matr[i,j];
//                         matr[i,j] = matr[i,m];
//                         matr[i,m] = t;
//                     }  
//             }
//        }   
//     }
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
// PrintArray(matrix);
// UporyadElemArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка


// Console.WriteLine("Введите количество строк: ");
// int strokiArray = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int stolbciArray = int.Parse(Console.ReadLine());
// int[,] matrix = new int[strokiArray, stolbciArray];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(0, 11);
//     }
// }
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

// void SumElStrokiArray(int[,] matr)
// {
//     int index = 0;
//     int[] temparray = new int[strokiArray];

//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             sum = sum + matr[i, j];
//         }
//         temparray[i] = sum;
//     }
//     Console.WriteLine();
//     int minchislo = temparray[0];
//     for (int k = 0; k < temparray.Length; k++)
//         {
//             if (minchislo > temparray[k])
//             {
//                 minchislo = temparray[k];
//                 index = k;
//             }
//         }
//    Console.WriteLine($"номер строки с наименьшей суммой элементов: {index+1} строка");
// }
// Console.WriteLine();
// PrintArray(matrix);
// Console.WriteLine();
// SumElStrokiArray(matrix);



// Задача 58: Задайте два двумерных массива (от 0 до 10). Напишите программу, которая 
// будет находить произведение двух массивов (поэлементное).
// Например, даны 2 массива:
// 2 4
// 3 2

// 3 4
// 3 3
// Результирующая матрица будет:
// 6 16
// 9 6

// Console.WriteLine("Введите количество строк: ");
// int strokiArray = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int stolbciArray = int.Parse(Console.ReadLine());
// int[,] matrix1 = new int[strokiArray, stolbciArray];
// int[,] matrix2 = new int[strokiArray, stolbciArray];
// void zapolnArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(0, 11);
//         }
//     }
// }
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
// void ProizvedArray(int[,] matr3, int[,] matr1, int[,] matr2)
// {
//     for (int i = 0; i < matr1.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr1.GetLength(1); j++)
//         {
//             matr3[i, j] = matr1[i, j] * matr2[i, j];
//         }
//     }
// }
// Console.WriteLine();
// zapolnArray(matrix1);
// zapolnArray(matrix2);
// PrintArray(matrix1);
// Console.WriteLine();
// PrintArray(matrix2);
// Console.WriteLine("Произведение массивов:");
// int[,] matr4 = new int[strokiArray, stolbciArray];
// ProizvedArray(matr4, matrix1, matrix2);
// PrintArray(matr4);


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] array = new int[2, 2, 2];
void zapolnenie(int[,,] matr)
{
    // int[]matr1 = new int[99];
    // for (int i=0; i<100;i++)
    // {
    //     int x = new Random().Next(10, 100);
    //     if (matr1[i] == x)
    //     {
    //         int y = new Random().Next(10, 100);
    //         matr1[i]=y;
    //     }
    //     else continue;

    // }

    // int l = new Random().Next(10, 101); 
    int[] arr = new int[8];
    for (int i = 0; i < arr.Length; i++)
    {
        int x = new Random().Next(10, 101);
        for (q = 0; q < 8; q++) { if (arr[q] == x) Povtor;
        }
    }
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {

                matr[i, j, k] = arr[i];

                Console.Write(matr[i, j, k] + " ");
            }
        }
    }
}
zapolnenie(array);












// Доп.Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07