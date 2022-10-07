// // // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// // Console.Write("Введите число 1: ");
// //
// int a = Convert.ToInt32(Console.ReadLine());
// // Console.Write("Введите число 2: ");
// //
// int b = Convert.ToInt32(Console.ReadLine());
// // Console.Write("Введите число 3: ");
// //
// int c = Convert.ToInt32(Console.ReadLine());
// // Console.Write("Введите число 4: ");
// //
// int d = Convert.ToInt32(Console.ReadLine());
// // Console.Write("Введите число 5: ");
// //
// int e = Convert.ToInt32(Console.ReadLine());
// //
// int count = 0;
// //
// int [] array = {a, b, c, d, e};
// // for 
// int i = 0; i < array.Length; i++)
// // if (array[i] > 0)
// count++;
// Console.WriteLine($"Количество чисел > 0: {count}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//  Console.Clear();
Console.Write("Введите координату b1: ");
double b1 = Convert.ToInt32(Console.ReadLine()); // 2
Console.Write("Введите координату k1: ");
double k1 = Convert.ToInt32(Console.ReadLine()); // 5
Console.Write("Введите координату b2: ");
double b2 = Convert.ToInt32(Console.ReadLine()); // 4 
Console.Write("Введите координату k2: ");
double k2 = Convert.ToInt32(Console.ReadLine()); // 9
double m = b2 - b1;
double n = k1 - k2;
Console.WriteLine("m " + m);
Console.WriteLine("n " + n);
double x = m / n;
Console.WriteLine("b1 " + b1);
Console.WriteLine("k1 " + k1);
Console.WriteLine("b2 " + b2);
Console.WriteLine("k2 " + k2);
Console.WriteLine("x " + x);
double y = k2 * x + b2;
Console.WriteLine($"Точка пересечения двух прямых: {(x, y)}");
