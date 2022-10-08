

Console.Clear();
Console.WriteLine("Введите цифру, соответствующую дню недели: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a < 1 || a > 7)
    Console.WriteLine("Попробуй еще раз!");

else if( a >= 1 && a <= 5)
    Console.WriteLine("Нет!");

else if( a >= 6 || a <= 7)
   Console.WriteLine("Да!");
