static int stepen(int a, int b)
{
    int count = 0;
    int s = 1;
    while (count < b)
    {
        s = s * a;
        count ++;
    }
    return s;
}
Console.Write("Введите a : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b : ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(stepen(a, b));