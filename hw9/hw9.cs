/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

/*Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{PrintNumbers(N, 1) }");

string PrintNumbers(int start, int end)
{
    if(start == end) return start.ToString();
    
    return (start +" "+ PrintNumbers(start - 1, end));
}*/


/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма чисел = {SumNumbers(M, N)}");

int SumNumbers(int M, int N)
{
    if (M != N)
        if (M < N)
            return SumNumbers(M + 1, N) + M;
        else
            return SumNumbers(M - 1, N) + M;
    else return M;
}



/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n. Выполнить с помощью рекурсии.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

/*Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"функция Аккермана = {Akkerman(m,n)}");

long Akkerman(long m, long n)
{
    if( m > 0 )
        if( n > 0)
            return Akkerman(m-1, Akkerman(m, n-1));
        else
            return Akkerman(m-1, 1);
    else
        return n+1;
}*/
