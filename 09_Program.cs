﻿// Задача 64: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""

/* int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + "," + PrintNumbers(start + 1, end));
}
Console.WriteLine(PrintNumbers(M, N)); */

//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

/* int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
 
int SumNumbers(int M, int N)
{ 
int start = M;
int end = N;
if (M > N) 
{ 
start = M;
end = N;
}
return (start + end) * (end - start +1) / 2;
}
Console.WriteLine($"Сумма натуральных чисел в промежутке от {M} до {N} -> {SumNumbers(M, N)} ");  */


//Задача 68: Напишите программу вычисления функции Аккермана с 
//помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

/* Функция Аккермана определяется рекурсивно для неотрицательных целых чисел m и n следующим образом:
A(m,n)=n+1, при m=0
A(m,n)=A(m−1,1), при m>0, n=0
A,(m,n)=A(m−1,A(m,n−1), при m>0, n>0 */

/* int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int Akkerman(int m, int n)
{
    if (m == 0) 
    {
        return n + 1;
    }
    if (m > 0 && n == 0) 
    {
        return Akkerman(m - 1, 1);
    }
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
Console.WriteLine($"A(m,n) = {Akkerman(m, n)}");  */

