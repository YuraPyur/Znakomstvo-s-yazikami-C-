// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("введите число");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine($"N = {m} -> " + $"{ChisPoUbivaniu(m)}");

// string ChisPoUbivaniu(int number)
// {

//     if (number == 1) return "1 ";
//     return $"{number} " + $"{ChisPoUbivaniu(number - 1)}";
// }



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Начало диапозона");
// int e = int.Parse(Console.ReadLine());
// Console.WriteLine("Конец диапозона");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма натуральных чисел от {e} до {m} равна {SumChiselDiapozona(m, e)}");

// int SumChiselDiapozona(int number, int end)
// {

//     if (number == end) return end;
//     return number + SumChiselDiapozona(number - 1, end);
// }



// Задача 68: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.WriteLine("Первое неотрицательное число");
// int e = int.Parse(Console.ReadLine());
// Console.WriteLine("Второе неотрицательное число");
// int second = int.Parse(Console.ReadLine());
// if (e>-1 && second>-1) 
// {
//    Console.WriteLine($"Функция Аккермана: А({e},{second}) = {Akkerman(e,second)}");
// }
// else Console.WriteLine("Введите неотрицательные числа"); 

// int Akkerman(int n, int m)
// {
//     if (n==0) return m+1;
//     else if (n>0 && m==0) return Akkerman(n-1,1);
//     return Akkerman(n-1,Akkerman(n,m-1));
// }

