// Задача 1: Задайте массив из 10 элементов, заполненный случайными числами
//  из промежутка [-9, 9]. Найдите суммы отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел
//  равна 29, сумма отрицательных равна -20.


// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++) 
// {
//     array[i] = new Random().Next(-9,10);
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine();
// int sumPolozh = 0;
// int sumOtriz = 0;
// for (int j = 0; j < array.Length; j++)
// {
//     if (array[j] > 0)
//     {
//         sumPolozh = sumPolozh + array[j];
//     }
//     else 
//     {
//         sumOtriz = sumOtriz + array[j];
//     }
// }
// Console.WriteLine("Сумма положительных " + sumPolozh);
// Console.WriteLine("Сумма отрицательных " + sumOtriz);



// Задача 2: Задайте массив из 10 элементов и положительные элементы замените
//  на соответствующие отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++) 
// {
//     array[i] = new Random().Next(-9,10);
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine();
// int perevertish = 0;
// for (int j = 0; j < array.Length; j++)
// {
//     perevertish = -1 * array[j];
//     Console.Write(perevertish + " ");
// }



