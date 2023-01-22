//Найти расстояние между точками в пространстве 2D/3D
Console.Clear();
Console.Write("Введите Х1 не равный 0: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите Y1 не равный 0: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите Z1 не равный 0: ");
int z1 = int.Parse(Console.ReadLine());
Console.Write("Введите Х2 не равный 0: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите Y2 не равный 0: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите Z2 не равный 0: ");
int z2 = int.Parse(Console.ReadLine());

while (x1 == 0 || y1 == 0 || z1==0 || x2 == 0 || y2 == 0 || z2==0)
{
    Console.Write("Введите Х1 не равный 0: ");
    x1 = int.Parse(Console.ReadLine());
    Console.Write("Введите Y1 не равный 0: ");
    y1 = int.Parse(Console.ReadLine());
    Console.Write("Введите Z1 не равный 0: ");
    z1 = int.Parse(Console.ReadLine());
    Console.Write("Введите Х2 не равный 0: ");
    x2 = int.Parse(Console.ReadLine());
    Console.Write("Введите Y2 не равный 0: ");
    y2 = int.Parse(Console.ReadLine());
    Console.Write("Введите Z2 не равный 0: ");
    z2 = int.Parse(Console.ReadLine());
}
int x = x2-x2;
int y = y2-y1;
int z = z2-z1;

//int dist=Convert.ToInt32(Math.Sqrt(x*x*+y*y+z*z));
double dist=Math.Sqrt(x*x*+y*y+z*z);
Console.WriteLine("Растояние между точками: "+dist);