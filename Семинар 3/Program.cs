// Шпаргалка
// Циклы
// ВАЖНО! Стараться не делать бесконечных циклов while (true) и проверять условие
// while - работает, пока выполняется условие

// int x = 1;
// while (x < 5) // пока x меньше 5: 1, 2, 3, 4
// {
//     Console.WriteLine(x); // Вывод x в консоль
//     x++; // увеличение переменной на 1
//     // равнозначно с:
//     // x += 1;
//     // x = x + 1;
// }

// do .. while - похож на while, но сначала идёт первое действие, а потом проверка условия
// int x = 10;
// do
// {
//     Console.WriteLine("Несмотря на то, что условие не выполняется, всё равно совсершаем первое действие");
// } while (x < 10); // x == 10, условие не выполняется

// for - цикл с параметрами
// первый параметр - действия до итерации. В нашем случае, объявляем переменную
// второй параметр - условие
// третий параметр - действия после итерации. В нашем случае, увеличиваем переменную на 1
// for (int i = 1; i < 5; i++)
// {
//     Console.WriteLine(i); // Вывод в консоль переменной i
// }

// Работа со строками
// Добавление переменных в строку
// int x = 5;
// // $ - ставится в начале строки перед двойными кавычками. Говорит о том, что в эту строку можно вставить переменную
// // внутри строки (между двойными кавычками) указываются переменные в фигурных скобках
// string str = $"Значение x = {x}";
// Console.WriteLine(str);
// Длина строки:
// string str = "abc"; // три буквы
// Console.WriteLine(str.Length); // 3. Учитываются пробелы и непечатные символы

// switch - сравнение с набором значений
// int x = 0;
// switch (x)
// {
//     case 0:
//         Console.WriteLine("x равен 0");
//         break;
//     case 1:
//         Console.WriteLine("x равен 1");
//         break;
//     case 2:
//         Console.WriteLine("x равен 2");
//         break;
//     default:
//         Console.WriteLine("Дальше лень считать");
//         break;
// }

// Преобразование типов - изменение типа данных переменной
// string str = "123"; // "123"
// int a = int.Parse(str); // 123 - целое число
// // Равнозначно с:
// // int a = Convert.ToInt32(str); // 123 - целое число
// double b = double.Parse(str); // 123.0 - дробное число
// // Равнозначно с:
// // double b = Convert.ToDouble(str); // 123.0 - дробное число
// Console.WriteLine(str);
// Console.WriteLine(a / 2); // 61 - дробная часть отбрасывается, когда операции производятся над целыми числами
// Console.WriteLine(b / 2); // 61.5 - дробная часть на месте, потому что число дробное

// Математические операции:
// Math.Pow - возведение в степень
// первое число - которое возводится
// второе - степень
// double x = Math.Pow(5, 2); // 25
// double x = Math.Pow(5, 3); // 125
// Math.Sqrt - квадратный корень
// первое число - число из которого берётся корень
// double x = Math.Sqrt(25); // 5
// Console.WriteLine(x);



// Задача 1.
// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// A (2, 3) -> 1 четверть, x > 0, y > 0
// A (-5, -8) -> 3 четверть, x < 0, y < 0
// Console.WriteLine("Введите номер четверти");
// string a = Console.ReadLine();
// int x = int.Parse(a);
// if (x == 1)
//     {
//         Console.WriteLine("x > 0 и y > 0");
//     }
// if (x == 2)
//     {
//         Console.WriteLine("x < 0 и y < 0");
//     }
// if (x == 3)
//     {
//         Console.WriteLine("x < 0 и y < 0");
//     }
// if (x == 4)
//     {
//         Console.WriteLine("x > 0 и y < 0");
//     }
// if (x<1 || x>4)
//     {
//         Console.WriteLine("неверно");
//     }
// Задача 2.
// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
// Console.WriteLine("Введите X первой точки");
// string a = Console.ReadLine();
// double x1 = double.Parse(a);
// Console.WriteLine("Введите Y первой точки");
// string b = Console.ReadLine();
// double y1 = double.Parse(b);
// Console.WriteLine("Введите X второй точки");
// string c = Console.ReadLine();
// double x2= double.Parse(c);
// Console.WriteLine("Введите Y второй точки");
// string d = Console.ReadLine();
// double y2 = double.Parse(d);
// double R = Math.Sqrt((Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2)));
// Console.WriteLine("Расстояние между точками " + R);




// Задача 1 через switch
// Console.WriteLine("Введите номер четверти");
// string a = Console.ReadLine();
// int x = int.Parse(a);
// switch (x)
// {
//     case 1:
//         Console.WriteLine("x > 0 и y > 0");
//         break;
//     case 2:
//         Console.WriteLine("x < 0 и y < 0");
//         break;
//     case 3:
//         Console.WriteLine("x < 0 и y < 0");
//         break;
//     case 4:
//         Console.WriteLine("x > 0 и y < 0");
//         break;
//     default:
//         Console.WriteLine("нет информации");
//         break;
// }



// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
// Console.WriteLine("Введите N");
// string a = Console.ReadLine();
// int x = int.Parse(a);
// int y = 1;
// while (y <= x)
//  {  
//     Console.WriteLine(Math.Pow(y,2));
//     y++;
//  }



// Циклы
// ВАЖНО! Стараться не делать бесконечных циклов while (true) и проверять условие
// while - работает, пока выполняется условие

// int x = 1;
// while (x < 5) // пока x меньше 5: 1, 2, 3, 4
// {
//     Console.WriteLine(x); // Вывод x в консоль
//     x++; // увеличение переменной на 1
//     // равнозначно с:
//     // x += 1;
//     // x = x + 1;
// }

// do .. while - похож на while, но сначала идёт первое действие, а потом проверка условия
// int x = 10;
// do
// {
//     Console.WriteLine("Несмотря на то, что условие не выполняется, всё равно совершаем первое действие");
// } while (x < 10); // x == 10, условие не выполняется

// for - цикл с параметрами
// первый параметр - действия до итерации. В нашем случае, объявляем переменную
// второй параметр - условие
// третий параметр - действия после итерации. В нашем случае, увеличиваем переменную на 1
// for (int i = 1; i < 5; i++)
// {
//     Console.WriteLine(i); // Вывод в консоль переменной i
// }

// Работа со строками
// Добавление переменных в строку
// int x = 5;
// $ - ставится в начале строки перед двойными кавычками. Говорит о том, что в эту строку можно вставить переменную
// внутри строки (между двойными кавычками) указываются переменные в фигурных скобках
// string str = $"Значение x = {x}. Какой-то дальше текст";
// string str2 = "Значение x = " + x + ". Какой-то дальше текст";
// Console.WriteLine(str);
// Console.WriteLine(str2);
// Длина строки - количество элементов (букв):
// string str = "abc"; // три буквы
// Console.WriteLine(str.Length); // 3. Учитываются пробелы и непечатные символы
// строка - массив букв
// элементы массива считаются с нуля (называется индексом)
// string str = "Hello";
// // char ch = 'a'; // тип данных - символ
// // Console.WriteLine(str[2]); // 2 - это 3-я буква, 2 - индекс, то есть l
// // Console.WriteLine(str[0]); // 0 - это 1-я буква, 0 - индекс, то есть H
// for (int i = 0; i < str.Length; i++)
// {
//     Console.WriteLine(str[i]);
// }


// switch - сравнение с набором значений
// int x = 10;
// switch (x)
// {
//     case 0:
//         Console.WriteLine("x равен 0");
//         break;
//     case 1:
//         Console.WriteLine("x равен 1");
//         break;
//     case 2:
//         Console.WriteLine("x равен 2");
//         break;
//     default:
//         Console.WriteLine("Дальше лень считать");
//         break;
// }

// Преобразование типов - изменение типа данных переменной
// string str = "123"; // "123"
// // int a = int.Parse(str); // 123 - целое число
// // Равнозначно с:
// int a = Convert.ToInt32(str); // 123 - целое число
// double b = double.Parse(str); // 123.0 - дробное число
// // Равнозначно с:
// // double b = Convert.ToDouble(str); // 123.0 - дробное число
// Console.WriteLine(str);
// Console.WriteLine(a / 2); // 61 - дробная часть отбрасывается, когда операции производятся над целыми числами
// Console.WriteLine(b / 2); // 61.5 - дробная часть на месте, потому что число дробное

// Математические операции:
// Math.Pow - возведение в степень
// первое число - которое возводится
// второе - степень
// double x = Math.Pow(5, 2); // 25
// double x = Math.Pow(5, 3); // 125
// Math.Sqrt - квадратный корень
// первое число - число из которого берётся корень
// double x = Math.Sqrt(25); // 5
// Console.WriteLine(x);

// ДЗ, задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Вариант 1:
// Console.WriteLine("Введите число");
// string number = Console.ReadLine();
// int a = int.Parse(number);

// if (a >= 100)
// {
//     while (a > 999)
//     {
//         a = a / 10;
//     }
//     int third = a % 10;
//     Console.WriteLine("Третье число " + third);
// }
// else
// {
//     Console.WriteLine("Третьего числа нет");
// }
// Вариант 2:
// Console.Write("Введите число: ");
// string num = Console.ReadLine();
// if (num.Length > 2)
// {
//     Console.WriteLine("Третья цифра: " + num[2]);
// }
// else
// {
//     Console.WriteLine("Третьей цифры в числе нет");
// }

// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.WriteLine("Введите x");
// string textX = Console.ReadLine();
// int x = int.Parse(textX);

// Console.WriteLine("Введите y");
// string textY = Console.ReadLine();
// int y = int.Parse(textY);

// if (x > 0 && y > 0)
// {
//     Console.WriteLine("1-я четверть");
// }
// if (x < 0 && y > 0)
// {
//     Console.WriteLine("2-я четверть");
// }
// if (x < 0 && y < 0)
// {
//     Console.WriteLine("3-я четверть");
// }
// if (x > 0 && y < 0)
// {
//     Console.WriteLine("4-я четверть");
// }