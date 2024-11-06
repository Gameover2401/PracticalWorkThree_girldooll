Console.WriteLine("Введите три числа: a,b,c");
Console.Write("a= ");
double a =Convert.ToDouble(Console.ReadLine());
Console.Write("b= ");
double b=Convert.ToDouble(Console.ReadLine());
Console.Write("c= ");
double c =Convert.ToDouble(Console.ReadLine());
if (a + b + c == 0)
{
    Console.WriteLine("Сумма a+b+c=0");
    return;
}
double y = (a * a + b * b + c * c) / (a + b + c);
Console.WriteLine($"y= {y}");
double e = Math.Exp(y);
Console.WriteLine($"ближайшая экспонента к y={e}");


