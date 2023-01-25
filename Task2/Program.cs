// По двум заданным числам проверять является ли одно квадратом другого
Console.Write("Введите целое большее число ");
int bigvalue = int.Parse(Console.ReadLine()!);
Console.Write("Введите меньшее число ");
int smallvalue = int.Parse(Console.ReadLine()!);
int osd = bigvalue / smallvalue;
if (osd==smallvalue)
{
    Console.Write("Большее число является квадратом меньшего");
}
else 
{
    Console.Write("Большее число  не является квадратом меньшего");
}