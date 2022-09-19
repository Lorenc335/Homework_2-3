Console.WriteLine("Программа выводит все натуральные числа в промежутке [n, m]");
Console.Write("Введите n : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите m : ");
int m = Convert.ToInt32(Console.ReadLine());
int tess ;
if (n > m)
{
    tess = n;
    n = m;
    m = tess;
}
for (int i = n; i < m + 1; i++)
{
    Console.Write( i );
    Console.Write(" ");
}