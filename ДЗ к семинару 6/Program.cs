// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// Console.WriteLine("Введите числа через запятую");
// int col = 0;
// string x = Console.ReadLine();
// var array = x.Split(',').Select(int.Parse).ToArray();
// for (int i = 0; i < array.Length; i++) 
// {
//     if (array[i]>0)
//     {
//         col++;
//     }
// }
// Console.WriteLine($"Количество чисел больше нуля равно {col}");




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Console.WriteLine("Введите b1");
// double b1 = double.Parse(Console.ReadLine());
// Console.WriteLine("Введите k1");
// double k1 = double.Parse(Console.ReadLine());
// Console.WriteLine("Введите b2");
// double b2 = double.Parse(Console.ReadLine());
// Console.WriteLine("Введите k2");
// double k2 = double.Parse(Console.ReadLine());
// double x = 0;
// double y = 0;
// if (k1 == k2)
// {
//     if (b1 == b2)
//     {
//         Console.WriteLine("Прямые совпадают");
//     }
//     else
//     {
//         Console.WriteLine("Прямые не пересекаются");
//     }
// } 
// else
// {
//     x = (b2-b1)/(k1-k2);
//     y = k1*x+b1;
//     Console.WriteLine($"Координаты точки пересечения - ({x};{y})");
// }
