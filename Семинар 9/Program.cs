
// Console.WriteLine("введите число");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine($"{m} -> {Sum(m)}");
// int Sum(int number)
// {
//     if (number==0) return 0;
//     return (number%10 + Sum(number/10));
// }

// Задача 1. Задайте значение N. Напишите программу, которая выведет
//  все натуральные числа в промежутке от 1 до N.

// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Console.WriteLine("введите число");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine(Sum(m));

// string Sum(int number)
// {
    
//     if (number ==1) return "1 ";
//     return $"{Sum(number-1)}" + $"{number} ";
// }


// Задача 2. Напишите программу, которая на вход принимает два числа 
// A и B, и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// int IntPow(int a, int b)
// {
//     if (b==0) return 1;
//     return IntPow(a,b-1)*a;
// }
// Console.WriteLine("Введите значение А");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите значение B");
// int b = int.Parse(Console.ReadLine());
// Console.WriteLine(IntPow(a,b));