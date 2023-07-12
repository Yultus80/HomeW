/*
 Задача 54: Задайте двумерный массив. Напишите программу,
  которая упорядочит по убыванию элементы каждой строки 
  двумерного массива.
 Например, задан массив:
 1 4 7 2
 5 9 2 3
 8 4 2 4
 В итоге получается вот такой массив:
 7 4 2 1
 9 5 3 2
 8 4 4 2
 */

/*int[,] table = new int[3, 4];
FillArrayRandom(table);
PrintArray(table);
SortToLower(table);
Console.WriteLine();
PrintArray(table);

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
*/

/*Задача 57: Составить частотный словарь элементов двумерного массива.
 Частотный словарь содержит информацию о том, сколько раз встречается
  элемент входных данных.
1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза*/

/*void Print2DArray(int[,] int2DArray)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.DarkGreen;

    for (int i = 0; i < int2DArray.GetLength(0); i++)
    {
        for (int j = 0; j < int2DArray.GetLength(1); j++)
        {
            Console.Write($"{int2DArray[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.White;
}

int[,] Create2DimArray(int hight, int length, int min, int max)
{
    int[,] int2DArray = new int[hight, length];

    for (int i = 0; i < hight; i++)
    {
        for (int j = 0; j < length; j++)
        {
            int2DArray[i, j] = new Random().Next(min, max);
        }
    }

    return int2DArray;
}

Console.WriteLine("Составить частотный словарь элементов двумерного массива");

bool isInArray(int value, int[,] int2DArray)
{
    foreach (int item in int2DArray)
    {
        if (item == value) return true;
    }
    return false;
}

int countArrayElement(int value, int[,]int2DArray)
{
    int counter = 0;
    foreach (int item in int2DArray)
    {
        if (value == item) counter++;
    }
    return counter;
}

int[,] GetFrequencyArray(int[,] int2DArray)
{
    int[,] frequencyArray = new int[int2DArray.Length, 2];
    int element = 0;
    int zeroElement = 0;

    foreach (int item in int2DArray)
    {
        if (!isInArray(item, frequencyArray) && item != 0)
        {
            frequencyArray[element, 0] = item;
            frequencyArray[element, 1] = countArrayElement(item, int2DArray);
        }
        else if(item == 0 && zeroElement == 0)
        {
            frequencyArray[element, 1] = countArrayElement(item, int2DArray);
            zeroElement++;
        }
        element++;
    }
    return frequencyArray;
}

void PrintFrequencyArray(int[,] frequencyArray)
{
    for (int i = 0; i < frequencyArray.GetLength(0); i++)
    {
        if(frequencyArray[i,1] != 0)
            Console.WriteLine($"{frequencyArray[i,0]} встречается {frequencyArray[i,1]} раз");
    }
}

int[,] myArray = Create2DimArray(3, 5, -2, 3);
Print2DArray(myArray);
int[,] myFrArray = GetFrequencyArray(myArray);
PrintFrequencyArray(myFrArray);

Console.WriteLine("Нажмите любую клавишу, чтобы продолжить");
Console.ReadKey();
Console.Clear();*/


/*Задача 58: Задайте две матрицы. Напишите программу, которая будет 
находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
 
 

 
 /*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
 которая будет построчно выводить массив, добавляя индексы каждого элемента.
 Массив размером 2 x 2 x 2
 66(0,0,0) 25(0,1,0)
 34(1,0,0) 41(1,1,0)
 27(0,0,1) 90(0,1,1)
 26(1,0,1) 55(1,1,1)
 */

/*int[,,] array3D = new int[2, 2, 2];
FillArray(array3D);
PrintIndex(array3D);

void PrintIndex(int[,,] arr)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

void FillArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}*/
 
 /*
 Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
 Например, на выходе получается вот такой массив:
 01 02 03 04
 12 13 14 05
 11 16 15 06
 10 09 08 07
 */
int len = 4;
int[,] table = new int[len, len];
FillArraySpiral(table, len);
PrintArray(table);

void FillArraySpiral(int[,] array, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
