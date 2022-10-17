//Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

//решение задачи.
//задаем массив
/* void FillArray(int[,] array, int min, int max) 
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        // i, m, k, j
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
}

// Напечатать массив
void PrintArray(int[,] inputArray)
{
for (int i = 0; i < inputArray.GetLength(0); i++)
{
    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
        Console.Write(inputArray[i, j] + "\t"); // Tab между элементами
    }
    Console.WriteLine();
}
} */

/* void Zadacha54()
{
 Random random = new Random();
    int rows = random.Next(4, 4);
    int columns = random.Next(4, 4);
    int[,] array = new int[rows, columns];
    FillArray(array, 0, 10);
    PrintArray(array);
    
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    { 
       for (int k = 0; k< rows - 1; k++)
       {
        if (array[i, k] < array[i, k+1])
        {
            int temp = array[i, k + 1];
            array[i, k + 1] = array[i, k];
            array[i, k] = temp;
        }
        }
    }
}

Console.WriteLine();
PrintArray(array);
}
Zadacha54(); */

/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка */


/* void Zadacha56()
{
 Random random = new Random();
    int rows = random.Next(4, 4);
    int columns = random.Next(4, 4);
    int[,] array = new int[rows, columns];
    FillArray(array, 0, 10);
    PrintArray(array);
     int minSumRow = 0;
     int SumRowNumbers(int[,] array, int i)
{
  int sumRow = array[i,0];
  for (int j = 1; j < rows; j++)
  {
    sumRow += array[i,j];
  }
  return sumRow;
}
     int sumRow = SumRowNumbers(array, 0);
     for (int i = 0; i < rows; i++)
     {
       int temp = SumRowNumbers(array, i);
       if (sumRow > temp)
       {
        sumRow = temp;
        minSumRow = i;
       }
     }
     
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minSumRow+1}");
    }
Zadacha56(); */

/* Задача 58: Задайте две матрицы. Напишите программу, которая будет 
находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */
/* 
void Zadacha58()
{
int[,] matrix_1 = new int [2, 2]; 
int[,] matrix_2 = new int [2, 2];

void FillArray(int[,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] inputArray)
{
for (int i = 0; i < inputArray.GetLength(0); i++)
{
    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
        Console.Write(inputArray[i, j] + "\t"); // Tab между элементами
    }
    Console.WriteLine();
}
}
 int[,] matrixProduct = new int[2, 2];
 void Product(int[,] matrix_1, int[,] matrix_2)
{
   
    for (int i = 0; i < matrix_1.GetLength(0); i++)
{
    for (int j = 0; j < matrix_2.GetLength(1); j++)
    { 
       int sum = 0;
       for (int k = 0; k < matrixProduct.GetLength(1); k++)
       {
        sum += matrix_1[i, k] * matrix_2[k, j]; 
        }
        matrixProduct[i, j] = sum;
       }
}

}FillArray(matrix_1);
FillArray(matrix_2);
PrintArray(matrix_1);
Console.WriteLine();
PrintArray(matrix_2);
Console.WriteLine();
Product(matrix_1, matrix_2);
PrintArray(matrixProduct);
}
Zadacha58(); */

/* 
