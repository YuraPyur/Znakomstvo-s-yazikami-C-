// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
// РЕШЕНИЕ:
// Console.WriteLine("Введите первое число");
// string first = Console.ReadLine();
// int a = int.Parse(first);
// Console.WriteLine("Введите второе число");
// string second = Console.ReadLine();
// int b = int.Parse(second);
// if (a > b)
// {
//     Console.WriteLine("большее " + a + "," + " меньшее " + b);
// }
// else
// {
//     Console.WriteLine("большее " + b + "," + " меньшее " + a);
// }


// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22
// РЕШЕНИЕ:
// Console.WriteLine("Введите первое число");
// string first = Console.ReadLine();
// int a = int.Parse(first);
// Console.WriteLine("Введите второе число");
// string second = Console.ReadLine();
// int b = int.Parse(second);
// Console.WriteLine("Введите третье число");
// string thee = Console.ReadLine();
// int c = int.Parse(thee);
// if (a > b)
// {
//     if (a > c)
//     {
//         Console.WriteLine("макисмальное " + a);
//     }
//     else 
//     {
//         Console.WriteLine("макисмальное " + c);
//         }
// }
// else
// {
//     if (b > c)
//     {
//         Console.WriteLine("макисмальное " + b);
//     }
//     else 
//     {
//         Console.WriteLine("макисмальное " + c);
//         }
// }


// Задача 6: Напишите программу, которая на вход принимает число 
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
// РЕШЕНИЕ:
// Console.WriteLine("Введите число");
// string first = Console.ReadLine();
// int a = int.Parse(first);
// if (a%2 == 0)
// {
//     Console.WriteLine("четное число");
// }
// else
// {
//     Console.WriteLine("нечетное число");
// }


// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
// РЕШЕНИЕ:
// Console.WriteLine("Введите число");
// string first = Console.ReadLine();
// int a = int.Parse(first);
// int b = 2;
// while (b < a)
// {
//     Console.WriteLine(b);
//     b = b + 2;
// }