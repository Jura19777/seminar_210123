// По двум заданным числам проверять является ли одно квадратом другого
Console.Clear();
Console.Write("Введите первое число : ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число : ");
int b = int.Parse(Console.ReadLine());

if (a * a == b) Console.WriteLine("Второе число : " + b + " является квадратом числа " + a);
else
    if (b * b == a) Console.WriteLine("Первое число : " + a + " является квадратом числа " + b);
else Console.WriteLine("Ни одно число не является квадратом другого числа - " + b +", "+ a);