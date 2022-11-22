// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. Не используя Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int VStepen (int number, int stepen)
// {
//     int result = 1;
//     for (int i = 1; i<=stepen; i++)
//     {
//         result = result*number;
//     }
//     return result;
// }
// Console.WriteLine("Введите число: ");
// int x = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите степень: ");
// int y = int.Parse(Console.ReadLine());
// int z = VStepen(x,y);
// Console.WriteLine(z);





// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int Summcifr (int number)
// {
//         int a = number;
//         int result = 0;
//         string str = a.ToString();
//         int[] b = new int[str.Length];
//         for( int i=0; i< str.Length; i++)
//         {
//             b[i] = int.Parse(str[i].ToString());
//             result = result + b[i];
//         }
//         return result;
// }
// Console.WriteLine("Введите число:");
// int x = int.Parse(Console.ReadLine());
// int z = Summcifr(x);
// Console.WriteLine(z);




// Задача 29: Напишите программу, которая генерирует массив из 8 элементов 
// - случайных чисел (от 0 до 20) и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 3 -> [1, 2, 5, 7, 19, 6, 1, 3]
// int[] Arr (int[]number)
// {
//     int length = number.Length;
//     int index = 0;
//     while (index < length)
//     {
//         number[index] = new Random().Next(0,21);
//         index++;
//     }
//     return number;
// }
// Console.WriteLine("введите количество элементов:");
// int k = int.Parse(Console.ReadLine());
// int[] array = Arr(new int[k]);
// for (int i = 0; i < array.Length; i++) 
// {
//     Console.Write(array[i] + " ");
// }