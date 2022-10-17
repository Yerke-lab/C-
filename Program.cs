//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

/*
int[] array = new int[10];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,1000);
    Console.Write(array[i] + " ");
    if (array[i] % 2 == 0) count++;
}
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве = {count}");
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/*
int[] array = new int[5];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,100);
    Console.Write(array[i] + " ");
    if (i % 2 != 0) sum += array[i];
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {sum}");
*/ 

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


double[] array = new double[5];
for (int index = 0; index < array.Length; index++)
{
    array[index] = new Random().Next(0,100);
    Console.Write(array[index] + " ");
}
int j = 0;
double min = array[j];
int i = 0;
double max = array[i];
while (j < array.Length-1 && i < array.Length-1)
{
    j++;
    i++;
    if(min > array[j]) min = array[j];
    if(max < array[i]) max = array[i];
}
double diff = max - min;
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {diff}");
