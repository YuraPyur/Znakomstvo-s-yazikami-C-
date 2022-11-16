// напишите программу, которая выводит случайное число
// из отрезка и показывает наибольшую цифру из числа
// 78 -> 8

// int number = new Random().Next(10,100);
// Console.WriteLine("Случайное число: " + number);
// int first = number / 10; // 45/10 = 4
// int second = number % 10; // 45%10 = 5 т.е. 45-4*10=5

// if (first>second)
// {
//     Console.WriteLine("Наибольшая цифра числа: " + first);
// }
// if (second>first)
// {
//     Console.WriteLine("Наибольшая цифра числа: " + second);
// }
// if (first == second)
// {
//     Console.WriteLine("Цифры числа равны");
// }




// Задача 1. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
// int number = new Random().Next(100,1000);
// Console.WriteLine("Случайное число: " + number);
// int first = number / 100; // 45/10 = 4
// int second = number % 10; // 45%10 = 5 т.е. 45-4*10=5
// Console.WriteLine("Результат: " + first+second);


// Задача 2. Напишите программу, которая будет принимать на вход 
// два числа и выводить, является ли второе число кратным первому. 
// Если второе число не кратно числу первому, то программа 
// выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно
// Console.WriteLine("Введите первое число");
// string first = Console.ReadLine();
// int a = int.Parse(first);
// Console.WriteLine("Введите второе число");
// string second = Console.ReadLine();
// int b = int.Parse(second);
// if (a%b ==0)
// {
//     Console.WriteLine("кратно");
// }
// else
// {
//     Console.WriteLine("не кратно, остаток "+ a%b);
// }


// Задача 3. Напишите программу, которая принимает на вход число и 
// проверяет, кратно ли оно одновременно 7 и 23.
// 14  ->  нет
// 46  ->  нет
// 161 ->  да
// Console.WriteLine("Введите число");
// string first = Console.ReadLine();
// int a = int.Parse(first);
// if (a%7 ==0 && a%23 ==0)
// {
    
//         Console.WriteLine("да");
//     }
//     else
//     {
//         Console.WriteLine("нет");
//     }













// Масимальное из 3 чисел

// int first = 8;
// int second = 10;
// int third = 8;


// if (first == second || second == third || first == third)
// {
//     Console.WriteLine("Какие-то из чисел равны");
// }
// else if (first > second && first > third)
// {
//     Console.WriteLine("Первое число самое большое");
// }
// else if (second > first && second > third)
// {
//     Console.WriteLine("Второе число самое большое");
// }
// else if (third > first && third > second)
// {
//     Console.WriteLine("Третье число самое большое");
// }








// Условные выражения
// && - логическое И (должны выполняться все условия)
// int x = 11;
// if (x > 5 && x < 10)
// {
//     Console.WriteLine("Победа!");
// }
// else
// {
//     Console.WriteLine("Тоже победа, но другая");
// }


// || - логическое ИЛИ (должны выполниться хотя бы одно условие)
// int x = 11;
// if (x > 5 || x < 10)
// {
//     Console.WriteLine("Победа!");
// }
// else
// {
//     Console.WriteLine("Тоже победа, но другая");
// }

// ! - логическое НЕ (если было true станет false и наоборот)
// int x = 2;
// if (!(x > 5))
// {
//     Console.WriteLine("Победа!");
// }
// else
// {
//     Console.WriteLine("Тоже победа, но другая");
// }

// // Случайное число
// // Диапазон указывается через запятую.
// // От первого числа включительно до второго числа НЕ включительно
// int randomNumber = new Random().Next(10, 20); // от 10 до 19 включительно
// Console.WriteLine(randomNumber);

// Операции с числами
// % - остаток от деления
// 4 % 2 == 0
// Console.WriteLine(5 / 2); // 2.5 -> 2

// / - целая часть от деления (для целых чисел) или просто деление (для дробных чисел)
// 4 / 2 == 2
// 5 / 2 == 2
// Console.WriteLine(5 % 2); 


// Напишите программу, которая выводит случайное число
// из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

// int number = new Random().Next(10, 100); // от 10 включительно до 100 НЕ включительно
// Console.WriteLine("Случайное число: " + number);
// int first = number / 10; // 45 / 10 == 4
// int second = number % 10; // 45 % 10 == 5
// if (first > second)
// {
//     Console.WriteLine("Наибольшая цифра числа: " + first);
// }
// if (second > first)
// {
//     Console.WriteLine("Наибольшая цифра числа: " + second);
// }
// if (first == second)
// {
//     Console.WriteLine("Цифры числа равны");
// }