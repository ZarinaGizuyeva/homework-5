// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int [] array = new int[10];
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// array[i] = Convert.ToInt32(new Random().Next(100, 1000));
// for (int j = 0; j < array.Length; j++)
// if (array[j] % 2 == 0)
// count ++;
// Console.WriteLine("[" + string.Join(", ", array) + "]");
// Console.WriteLine(count);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int [] array = new int[15];
// int sum = 0;
// for (int i = 0; i < array.Length; i++)
// array[i] = Convert.ToInt32(new Random().Next(-20, 100));
// Console.WriteLine("[" + string.Join(", ", array) + "]");
// for (int j = 0; j < array.Length; j++)
// if (j % 2 != 0)
// sum = sum + array[j];
// Console.WriteLine(sum);


    // Дополнительная задача

int a = 3, b = 5, c =11;
int sum = a + b + c;
if (a % 1 == 0 && a % a == 0)
if (b % 1 == 0 && b % b == 0)
if (c % 1 == 0 && c % c == 0)
if ((a + b + c) % (a + b + c) == 0)
Console.WriteLine(sum);
Console.WriteLine("yes");



// Эту задачу не смогла решить :/
// Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


// double[] array = new double[5];
// double diff = 0;
// double max = array[0];
// double min = array [0];
// for (int i = 0; i < array.Length; i++)
// array[i] = Convert.ToInt32(new Random().Next() * 10);
// for (int j = 0; j < array.Length; j++) 
//     if (array[j] >  max) 
//     max = array[j];
//     else if (array[j] < min) 
//     min = array[j];
// diff = max - min;
// Console.WriteLine("[" + string.Join(", ", array) + "]");
// Console.WriteLine(diff);
    


