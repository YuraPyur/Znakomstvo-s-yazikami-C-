// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] array = new int[4];
// for (int i = 0; i < array.Length; i++) 
// {
//     array[i] = new Random().Next(100,1000);
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine();
// int colChetnich = 0;
// for (int j = 0; j < array.Length; j++)
// {
//     if (array[j] % 2 == 0)
//     {
//         colChetnich = colChetnich + 1;
//     } 
// }
// Console.WriteLine("Количество четных чисел: " + colChetnich);



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array = new int[4];
// for (int i = 0; i < array.Length; i++) 
// {
//     array[i] = new Random().Next(0,10); // убрать условие
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine();
// int sumNechIndex = 0;
// for (int j = 0; j < array.Length; j++)
// {
//     if (j % 2 == 1)
//     {
//         sumNechIndex = sumNechIndex + array[j];
//     } 
// }
// Console.WriteLine("Сумма чисел с нечетным индексом: " + sumNechIndex);



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// float[] array = new float[4];
// for (int i = 0; i < array.Length; i++) 
// {
//     array[i] = new Random().Next(0, 10); // убрать условие
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine();
// float maxChislo = array[0];
// float minChislo = array[0];
// for (int j = 0; j < array.Length; j++)
// {
//     if (array[j] > maxChislo)
//         {
//             maxChislo = array[j] ;
//         } 
//     if (array[j] < minChislo)
//         {
//             minChislo = array[j];
//         } 
// }
// Console.WriteLine("Разность между максимальным и минимальным числами: " + (maxChislo - minChislo));



// Дополнительно. Задания 3, 4 необязательные
// Задача 3: Задайте массив из 8 случайных чисел. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// Console.WriteLine("Введите число: ");
// int chisPolzov = int.Parse(Console.ReadLine());
// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++) 
// {
//     array[i] = new Random().Next(0,10); // убрать условие
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine();
// string x = "нет";
// for (int j = 0; j < array.Length; j++)
// {
//     if (array[j]== chisPolzov)
//     {
//         x = x.Replace("нет","да");
//     }
// }
// Console.WriteLine(x);



// Задача 4: Задайте массив из 12 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 12 элементов. В своём решении сделайте для 12
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] array = new int[12];
// for (int i = 0; i < array.Length; i++) 
// {
//     array[i] = new Random().Next(0,100); // убрать условие
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine();
// int x = 0;
// for (int j = 0; j < array.Length; j++)
// {
//     if (array[j] > 9 && array[j] < 100)
//     {
//         x = x + 1;
//     }
// }
// Console.WriteLine(x);