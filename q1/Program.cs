Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = b;
if (max < b)
{
    max = b;
    min = a;
}
if (max > b) min = b;
Console.Write("min = ");
Console.WriteLine( min );
Console.Write( "max = " );
Console.WriteLine( max );