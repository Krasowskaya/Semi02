// Задача 19 Напишите пjограмму, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
string array = Convert.ToString(Console.ReadLine());

    if(array[0]==array[4] && array[1]==array[3])
        Console.WriteLine("Pal");
    else
        Console.WriteLine("no");
