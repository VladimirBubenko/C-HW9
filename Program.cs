// HW9
//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// void ShowNumbers(int n)
// {
//     Console.Write(n + " ");
//     if (n > 1) ShowNumbers(n-1);
//     if (n < 1) ShowNumbers(n+1);
// }
// Console.WriteLine("Input N: ");
// ShowNumbers(Convert.ToInt32(Console.ReadLine()));

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// int SumNumber(int m, int n)
// {
//     if (m <= n) return SumNumber(m+1,n) + m;
//     return 0;
// }
// int result = SumNumber(1,15);
// Console.WriteLine(result);

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int m, int n)
{
    if (m == 0)
        return n+1;
    if (m >0 && n == 0)
        return Akkerman(m-1, 1);
    return Akkerman(m-1, Akkerman(m, n- 1));
}
Console.WriteLine(Akkerman(2,3));