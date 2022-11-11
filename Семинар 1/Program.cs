// Console.WriteLine("Введите число");
// string str = Console.ReadLine();
// int number = int.Parse(str);
// int square = number * number;
// Console.WriteLine("Квадрат вашего числа " + square);
// Console.WriteLine("Введите первое число");
// string first = Console.ReadLine();
// int a = int.Parse(first);
// Console.WriteLine("Введите второе число");
// string second = Console.ReadLine();
// int b = int.Parse(second);
// if (a == b * b)
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");
// }



// Console.WriteLine("Введите число");
// string second = Console.ReadLine();
// int b = int.Parse(second);
// int negativeb = b * -1;
// while (negativeb <= b)
// {
//     Console.WriteLine(negativeb);
//     negativeb++;
// }

// while (b > 0)
// {
//     Console.WriteLine(b);
//     b--;
// }




// // Типы данных
// // int - целое число
// int x = 5;
// int abc;
// // double - дробное число
// double y = 2.5;
// // string - строка
// string str = "Привет всем!)";
// // bool - логический тип данных. Может принимать значения true (истина) или false (ложь)
// bool b = y > x; // 2.5 > 5 == false

// // Блоки кода
// // Пространство между двумя фигурными скобками называется блок кода
// {
// }

// // Ветвление if..else
// if (x == 5) // == - проверка на равенство
// // если выражение в скобках верное, то выполняется этот блок кода
// {
//     Console.WriteLine("x это пять");
// }
// else 
// // если выражение не верное, то выполняется блок кода после else
// {
//     Console.WriteLine("x это НЕ пять");
// }

// // Цикл
// int a = 0;
// while (a < 5)
// // если условие в скобках верное, то выполняется этот блок кода
// {
//     Console.WriteLine(a);
//     a++; // увеличение a на единицу
//     // равнозначно с:
//     // a = a + 1;
//     // a += 1;
// }


// // Написать программу: программа получает число с консоли, 
// // возводит его в квадрат и выводит на экран

// // Console.WriteLine -- вывод сообщения в консоль
// Console.WriteLine("Привет! Введите число, чтобы мы возвели его в квадрат");
// // Console.ReadLine -- получаем текст с консоли
// string str = Console.ReadLine();

// // int.Parse -- переводит строку (string) в число (int)
// int number = int.Parse(str);

// // * -- умножение
// int square = number * number;

// Console.WriteLine("Квадрат вашего числа " + square);

// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

// Console.WriteLine("Введите число");
// string text = Console.ReadLine();
// Console.WriteLine(); // пустая строка для разделения
// int number = int.Parse(text); // например, 2
// int negativeNumber = number * -1; // 2 * -1 == -2
// while (negativeNumber <= number) // -2 <= 2 == true
// {
//     Console.WriteLine(negativeNumber); // выводим -2
//     // -2 + 1 == -1
//     negativeNumber++; // увеличение negativeNumber на единицу
//     // равнозначно с:
//     // negativeNumber = negativeNumber + 1;
//     // negativeNumber += 1;
// }

// int num = -5;
// int absNum = Math.Abs(num); // Модуль числа 
// Console.WriteLine(absNum);
