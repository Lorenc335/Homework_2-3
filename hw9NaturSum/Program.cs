static int NaturNumAdd(int n, int m)
{
    if (n == m) return m;
    else
    {
        return n + NaturNumAdd(n + 1, m);
    }
}

Console.Write("Введите первое число = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число = ");
int m = Convert.ToInt32(Console.ReadLine());
int tess;
if (n > m)
{
    tess = n;
    n = m;
    m = tess;
}
Console.WriteLine("Программа выводит сумму всех натуральных чисел промежутка [n, m]");
Console.WriteLine(NaturNumAdd(n, m));