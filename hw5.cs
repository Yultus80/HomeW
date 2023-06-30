/*Задача 34: Задайте массив заполненный случайными положительными
 трёхзначными числами. Напишите программу, которая покажет 
 количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

/*int[] startArray = GetArrey(6, 100, 999);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Четных элементов в массиве = {GetEvenCount(startArray)}");

int GetEvenCount(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item % 2 == 0) count++;
    }
    return count;
}*/

int[] GetArrey(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}





/*Задача 36: Задайте одномерный массив, заполненный случайными 
числами. Найдите сумму элементов, стоящих на нечётных ИНДЕКСАХ.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

/*int[] startArray = GetArrey(6, 0, 999);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Сумма элементов в массиве на нечетных позициях = {GetSum(startArray)}");

int GetSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum += array[i];
    }
    return sum;
}*/


/*Задача 38: Задайте массив целых двухзначных чисел. Найдите 
разницу между максимальным и минимальным элементов массива.
[22, 42, 15, 77, 65] => 77 - 15 = 62**/

int[] startArray = GetArrey(6, 10, 99);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Разница между макс и мин элементами в массиве = {GetDef(startArray)}");

int GetDef(int[] array)
{
    int min = array[0];
    int max = array[0];
    foreach (var item in array)
    {
        if (min > item) min = item;
        if (max < item) max = item;
    }
    return max - min;
}


