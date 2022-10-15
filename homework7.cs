// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Console.Clear();
// void InputMatrix(double[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// matrix[i, j] = Math.Round(new Random().NextDouble() * 10, 3);  
// Console.Write(matrix[i, j] + " \t");
// }
// Console.WriteLine();
// }
// }

// Console.Write("Введите кол-во строк: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int m = Convert.ToInt32(Console.ReadLine());
// double[,] matrix = new double[n, m];
// InputMatrix(matrix);


// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Console.Clear();

// Console.Write("Введите кол-во строк: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[n, m];

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 15);
//             Console.Write(matrix[i, j] + " \t");
//         }
//         Console.WriteLine();
//     }

//     double[] summ = new double[matrix.GetLength(1)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             summ[i] += matrix[j, i];      //подсчет суммы колонки
//         }
//         Console.Write($"Среднее арифметическое столбцов: " + summ[i] / matrix.GetLength(1)); //вывод среднего для колонки
//     }
// }

// InputMatrix(matrix);


// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 15);
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}
InputMatrix(matrix);
Console.Write("Введите позицию строки: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int column = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i + 1 == line && j + 1 == column)
            Console.WriteLine(matrix[i, j]);
        else if (line > matrix.GetLength(0) && column > matrix.GetLength(1))
            Console.WriteLine("Такого элемента нет");
    }

}


