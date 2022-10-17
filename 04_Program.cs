// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

//Решение
int GetNaturalDegree(int result, int A, int B)
{
    for (int i = 0; i <= B; i++)
    {
      result = Convert.ToInt32(Math.Pow(A, i));
    }
    return result;
}
Console.WriteLine("Введите число А:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int B = Convert.ToInt32(Console.ReadLine());
int result = 1;
Console.WriteLine($"{A}, {B} -> {GetNaturalDegree(result, A, B)}");


//Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

//Решение
Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int SumN(int N)
{
int count = Convert.ToString(N).Length;
int result = 0;
for (int i = 0; i < count; i ++)
{
result += N - (N - N % 10);
N = N / 10;
}
return result;
}
int sumN = SumN(N);
Console.WriteLine($"Сумма цифр числа {N} -> " + sumN);


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

//Решение
int[] GetArray (int size)
{
int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
}
return array;
}
Console.WriteLine("Введите размер массива:");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] resultArray = GetArray(sizeArray);
Console.Write($"Результат: {String.Join(", ", resultArray )} -> [ {String.Join("; ", resultArray )} ]");

