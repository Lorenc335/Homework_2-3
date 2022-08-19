int Main(int i)
{
    int d = i*i*i;
    return d;
}
Console.Write("введите число :");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i<n+1)
{
    Console.Write(Main(i));
    Console.Write(' ');
    i = i + 1;
}