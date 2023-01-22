// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Clear();
Console.Write("Введите число обозначающее день недели: ");
int a = int.Parse (Console.ReadLine());
string dey = "";
switch (a)
{
    case 1: dey = "понедельник";break;
    case 2: dey = "вторник";break;
    case 3: dey = "среда";break;
    case 4: dey = "четверг";break;
    case 5: dey = "пятница";break;
    case 6: dey = "суббота";break;
    case 7: dey = "воскресенье";break;
}

if (a == 6 || a==7)
{
    Console.WriteLine("Введенное число обозначающее день недели: " + dey + ", является выходным");
}
else
{
    Console.WriteLine("Введенное число обозначающее день недели: " + dey + ", является рабочим");
}