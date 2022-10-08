// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = n % 100;
int x = m / 10;

if ( n < 100 || n > 999)
    Console.WriteLine("Попробуй еще раз! ");
else 
    Console.WriteLine(x);