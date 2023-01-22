// Задать номер четверти, показать диапазоны для возможных координат
Console.Clear();
Console.Write("Введите Х не равный 0: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите Y не равный 0: ");
int y = int.Parse(Console.ReadLine());

while (x == 0 || y == 0)
{
    Console.WriteLine("Вы ввели 0, попробуйте еще");
    Console.Write("Введите Х не равный 0: ");
    x = int.Parse(Console.ReadLine());
    Console.Write("Введите Y не равный 0: ");
    y = int.Parse(Console.ReadLine());
}

if ((x > 0) && (y > 0)) Console.WriteLine("Кординаты в первой четверти: x=" + x + " y=" + y);
else
    if ((x < 0) && (y > 0)) Console.WriteLine("Кординаты во второй четверти: x=" + x + " y=" + y);
else
    if ((x < 0) && (y < 0)) Console.WriteLine("Кординаты в третьей четверти: x=" + x + " y=" + y);
else Console.WriteLine("Кординаты в четвортой четверти: x=" + x + " y=" + y);