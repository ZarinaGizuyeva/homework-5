// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.

// int Print(int m, int n)
// {
//     if (m == n)
//         return m;
//     return Print(m, n - 1) + n;
// }


// Console.Clear();
// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Сумма чисел от М до N равна ");
// Console.WriteLine(Print(m, n));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int A(int n, int m)
{
    {
        if (n == 0)
            return m + 1;
        else
          if ((n != 0) && (m == 0))
            return A(n - 1, 1);
        else
            return A(n - 1, A(n, m - 1));
    }
}
Console.Clear();
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Результат вычисления: ");
Console.WriteLine(A(n, m));