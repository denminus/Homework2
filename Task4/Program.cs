// Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("Введите по очереди координаты точки А (X,Y,Z) ");
double AX = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
double AY = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
double AZ = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите по очереди координаты точки B (X,Y,Z) ");
double BX = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
double BY = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
double BZ = Convert.ToDouble(Console.ReadLine());

double Lxy= Math.Sqrt(((Math.Pow((AX-BX), 2))+(Math.Pow((AY-BY), 2))));
double Lxyz= Math.Sqrt(((Math.Pow((AX-BX), 2))+(Math.Pow((AY-BY), 2))+(Math.Pow((AZ-BZ), 2))));

Console.WriteLine($"Расстояние между точками А и В в плоскости XY: {Lxy}");
Console.WriteLine($"Расстояние между точками А и В в пространстве XYZ: {Lxyz}");
