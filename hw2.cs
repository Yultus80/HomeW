/*Задача 10:

 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. (Проверка на трехзначность при вводе пользователем)
456 -> 5
782 -> 8
918 -> 1*/

/*Console.Write("Введите трехзначное число ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(N / 10 % 10);*/


/*Задача 13: Напишите программу, которая выводит третью 
цифру заданного числа или сообщает, что третьей цифры
 нет. (Максимум 100000)
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

/*Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()!);

if (number > 99 && number <= 999)
{
    int num = number % 10;
    Console.WriteLine($"Третья цифра = {num}");
}
if (number > 999 && number <= 9999)
{
    int num1 = number % 100 / 10;
    Console.WriteLine($"Третья цифра = {num1}");
}
if (number > 9999 && number <= 99999)
{
    int num2 = number % 1000 / 100;
    Console.WriteLine($"Третья цифра = {num2}");
}
if (number <= 99)
{
    Console.WriteLine("третьей цифры нет!");
}*/
