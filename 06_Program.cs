/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

//РЕШЕНИЕ

/* Console.WriteLine("Введите длину массива:");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
int posNumber = 0;
Console.WriteLine("Введите числа массива:");

for (int i = 0; i < M; i++)
{
 array[i] =  Convert.ToInt32(Console.ReadLine());
}
int fillArray (int[] array) {
for (int j = 0; j < M; j++) {
    if (array[j] > 0)    {
        posNumber++;
    }
} return posNumber;
}
Console.WriteLine($" {String.Join(", ", array)} -> {fillArray(array)}"); */


/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

//РЕШЕНИЕ

/* Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double x = ((b2 - b1) / (k1 - k2));
double y = (k2 * x) + b2;
Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y}) "); */

