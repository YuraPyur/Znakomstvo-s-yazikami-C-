// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// Console.WriteLine("Введите число");
// string a = Console.ReadLine();
// int b = int.Parse(a);
// if (b<=9999)
// {
//     Console.WriteLine("Не пятизначное число");
// }
// if (b>9999)
// {
//         if (a[0] == a[4] && a[1] == a[3])
//         {
//             Console.WriteLine("да, это палиндром");
//         }
//         else
//         {
//             Console.WriteLine("нет, это не палиндром");
//         }
// }



// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Console.WriteLine("Введите X первой точки");
// string a = Console.ReadLine();
// double x1 = double.Parse(a);
// Console.WriteLine("Введите Y первой точки");
// string b = Console.ReadLine();
// double y1 = double.Parse(b);
// Console.WriteLine("Введите Z первой точки");
// string c = Console.ReadLine();
// double z1 = double.Parse(c);
// Console.WriteLine("Введите X второй точки");
// string d = Console.ReadLine();
// double x2= double.Parse(d);
// Console.WriteLine("Введите Y второй точки");
// string e = Console.ReadLine();
// double y2 = double.Parse(e);
// Console.WriteLine("Введите Z второй точки");
// string f = Console.ReadLine();
// double z2 = double.Parse(f);
// double R = Math.Sqrt((Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2))+ Math.Pow((z2 - z1),2));
// Console.WriteLine("Расстояние между точками " + R);


// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// Console.WriteLine("Введите N");
// string a = Console.ReadLine();
// int x = int.Parse(a);
// int y = 1;
// while (y <= x)
//  {  
//     Console.WriteLine(Math.Pow(y,3));
//     y++;
//  }