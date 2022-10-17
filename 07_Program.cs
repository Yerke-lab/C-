/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

/* Console.WriteLine("Введите длину двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину ширину массива:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] twoDimArray = new double[m, n];
Random rnd = new Random();
void PrintArray(double[,] matr)
{
 for (int i = 0; i < m; i++)
 {
 for (int j = 0; j < n; j++)
 {
 Console.Write($"{matr[i, j]} ");
 }
 Console.WriteLine();
 }
}

void FillArray(double[,] matr)
{
 for (int i = 0; i < m; i++)
 {
 for (int j = 0; j < n; j++)
 {
 matr[i,j] = Convert.ToDouble(rnd.Next(-100, 100)/10.0);
 }
 }
}
FillArray(twoDimArray);
Console.WriteLine();
PrintArray(twoDimArray); */



/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

/* Console.WriteLine("Введите длину двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину ширину массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] twoDimArray = new int [m, n];
Random rnd = new Random();
void PrintArray(int[,] matr)
{
 for (int i = 0; i < m; i++)
 {
 for (int j = 0; j < n; j++)
 {
 Console.Write($"{matr[i, j]} ");
 }
 Console.WriteLine();
 }
}

void FillArray(int[,] matr)
{
 for (int i = 0; i < m; i++)
 {
 for (int j = 0; j < n; j++)
 {
 matr[i,j] = rnd.Next(0, 10);
 }
 }
}
FillArray(twoDimArray);
Console.WriteLine();
Console.WriteLine("введите число для поиска в двумерном массиве:");
int number = Convert.ToInt32(Console.ReadLine());
void FindNumber(int[,] matr)
{ int count = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
 {
 if (number == matr[i,j]) count++; 
  }
    }
    if (count > 0) Console.WriteLine($"{number} -> такое число есть в массиве");
    else Console.WriteLine($"{number} -> такого числа нет в массиве");
}
PrintArray(twoDimArray); 
FindNumber(twoDimArray); */

/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

/* Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] twoDimArray = new int [m, n];
Random rnd = new Random();
void PrintArray(int[,] matr)
{
 for (int i = 0; i < m; i++)
 {  for (int j = 0; j < n; j++)
  { Console.Write($"{matr[i, j]} ");  }
  Console.WriteLine(); } }

void FillArray(int[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
 { matr[i,j] = rnd.Next(0, 10); } } }
FillArray(twoDimArray);
Console.WriteLine();

void FindAverage(int[,] matr)
{
    for (int i = 0; i < m; i++)
    {int sum  = 0;
    double average  = 0;
        for (int j = 0; j < n; j++)
 {
 sum = sum + matr[i, j]; 
   }  average = sum / (double)n;
   Console.WriteLine($"Среднее арифметическое столбца: {Math.Round(average, 1)} ");
    } 
        }
PrintArray(twoDimArray); 
FindAverage(twoDimArray);  */

