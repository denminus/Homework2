Console.Write("введите номер дня недели ");
int value = int.Parse(Console.ReadLine()!);
if (value>=1 && value<=7) 
{
    
    if (value==6 || value==7)
{
    Console.WriteLine("этот номер дня недели соответствует выходному");
}
else Console.WriteLine("этот номер дня недели не соответствует выходному");
}
else 
{
    Console.WriteLine("это число не может быть номером дня недели");
}
