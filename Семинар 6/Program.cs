// Задача 1. Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.). 
// Элементы массива задаются случано и лежат в промежутке от -10 до 10
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


// int[] Arr (int[]number)
// {
//     int length = number.Length;
//     int index = 0;
//     while (index < length)
//     {
//         number[index] = new Random().Next(-10,11);
//         index++;
//     }
//     return number;
// }
// Console.WriteLine("введите количество элементов в массиве:");
// int k = int.Parse(Console.ReadLine());
// int[] array = Arr(new int[k]);
// for (int i = 0; i < array.Length; i++) 
// {
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine();

//    for (int i = 0; i <array.Length/2; i++)
//     {
//      int povor = array[i];
//      array[i] = array[array.Length-1-i];
//      array[array.Length-1-i] = povor;
    
//     }
//     for (int i = 0; i < array.Length; i++)
//     {
//     Console.Write(array[i] + " ");
//     }




// Задача 2. Вычислить среднее арифметическое положительных элементов 
// в одномерном массиве. 
// Элементы массива задаются случано и лежат в промежутке от -10 до 10
// [1, -5, 8, 4, -9] -> 4.33

// int[] Arr (int[]number)
// {
//     int length = number.Length;
//     int index = 0;
//     while (index < length)
//     {
//         number[index] = new Random().Next(-10,11);
//         index++;
//     }
//     return number;
// }
// Console.WriteLine("введите количество элементов в массиве:");
// int k = int.Parse(Console.ReadLine());
// int[] array = Arr(new int[k]);
// for (int i = 0; i < array.Length; i++) 
// {
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine();
// double sum = 0;
// double colPolo = 0;
// double sredArif = 0;
// for (int i = 0; i < array.Length; i++) 
// {
//     if (array[i]>0)
//     {
//         sum = sum + array[i];
//         colPolo++;
//     } 
// }
// sredArif = Math.Round(sum/colPolo,2);
// Console.WriteLine(sredArif);





// Задча 3. Задайте двумерный массив со случайными числами от -10 до 10. 
// Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.)
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


// Console.WriteLine("Введите количество строк: ");
// int stroki = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int stolbci = int.Parse(Console.ReadLine());
// int [,] matrix = new int[stroki,stolbci];
// for (int i = 0; i < matrix.GetLength(0);i++)
// {
//     for (int j = 0; j < matrix.GetLength(1);j++)
//     {
//         matrix[i,j] = new Random().Next(1,10);
//         Console.Write($"{matrix[i,j]} ");
//     }
//     Console.WriteLine();
// }
// int sum = 0;
// for (int i = 0; i < matrix.GetLength(0);i++)
// {
//     for (int j = 0; j < matrix.GetLength(1);j++)
//     {
//         if (i==j)
//         {
//             sum = sum + matrix[i,j];
//         }
//     } 
// }
// Console.WriteLine($"Сумма элементов, находящихся на главной диагонали - {sum}");