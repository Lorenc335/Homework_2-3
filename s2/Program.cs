Console.Write("Введите нормальное число ( больше двух знаков ): ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;
int x = 0;
while (a > 0)
{
    b = a % 10;
    x = x + b;
    a = a / 10;
}
Console.Write("Программа сочла нужным сложить каждый знак числа и вышло -> ");
Console.WriteLine(x);