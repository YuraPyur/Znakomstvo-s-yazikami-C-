// Задача 1: Задайте двумерный массив случайных чисел от 0 до 10. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

// int [,] matrix = new int[3,4];

// for (int i = 0; i < matrix.GetLength(0);i++)
// {
//     for (int j = 0; j < matrix.GetLength(1);j++)
//     {
//        matrix[i,j] = new Random().Next(0,11);
//        Console.Write($"{matrix[i,j]} ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Меняем первую и последнюю строки местами:");
// void MenyaemStrokiPervSPosl (int[,] matr)
// {
// for (int i = 0; i < matr.GetLength(1);i++)
// {
//         int k = matr[0,i];
//         matr[0,i] = matr[matr.GetLength(0)-1,i];
//         matr[matr.GetLength(0)-1,i] = k;
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
// MenyaemStrokiPervSPosl(matrix);
// PrintArray(matrix);




// Задача 2: Из двумерного массива случайных целых чисел от 0 до 10 удалить строку 
// и столбец, на пересечении которых расположен наименьший элемент.


// int [,] matrix = new int[3,4];

// for (int i = 0; i < matrix.GetLength(0);i++)
// {
//     for (int j = 0; j < matrix.GetLength(1);j++)
//     {
//        matrix[i,j] = new Random().Next(0,11);
//        Console.Write($"{matrix[i,j]} ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();
// int minEl = matrix[0,0];
// int o = 0;
// int k = 0;
// for (int i = 0; i < matrix.GetLength(0);i++)
// {
//     for (int j = 0; j < matrix.GetLength(1);j++)
//     {
//         if (matrix[i,j] < minEl) 
//         {
//             minEl = matrix[i,j];
//             o = i;
//             k = j;
//         }
//         else
//         {
//             continue;
//         }
//     }
    
// }
// Console.WriteLine($"индексы минимального значения: ({o},{k})");
// int [,] matrix1 = new int[2,3];
// for (int i = 0, i1 = 0; i < matrix.GetLength(0);i++)
// {
//     if (i!=o)
//     {
//     for (int j = 0, j1 = 0; j < matrix.GetLength(1);j++)
//     {
//         if (j!=k)
//         { 
//             matrix1[i1,j1]=matrix[i,j];    
//             j1++;
//         }
        
//     }
//     i1++;
//     }  
// }
// Console.WriteLine("Массив без столбца и строки, в котором был минимальный элемент:");
// for (int i = 0; i < matrix1.GetLength(0);i++)
// {
//     for (int j = 0; j < matrix1.GetLength(1);j++)
//     {
//        Console.Write($"{matrix1[i,j]} ");
//     }
//     Console.WriteLine();
// }
