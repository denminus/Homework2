// Задать номер четверти, показать диапазоны для возможных координат
Console.Write("Введите номер четверти координат ");
int value = int.Parse(Console.ReadLine()!);
if (value>=1 && value<=4)
{
    if (value==1) Console.WriteLine("x,y имеют положительные значения");
    if (value==2) Console.WriteLine("x имеет отрицательное значение, y имеет положительное значение");
    if (value==3) Console.WriteLine("x,y имеют отрицательные значения");
    if (value==4) Console.WriteLine("x имеет положительное значение, y имеет отрицательное значение");

    
}
else Console.WriteLine("Число не является номером четверти координат");







