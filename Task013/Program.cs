Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a < 100)
    Console.WriteLine("Третья цифра отсутствует");
else 
    Console.WriteLine(Convert.ToString(a)[2]);
    
