Console.Write("Введите a : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b : ");
int b = Convert.ToInt32(Console.ReadLine());
int count = 0;
int s = 1;
Console.Write("И получите МАГИЮ - ");
while (count < b)
{
    s = s * a;
count ++;
}
Console.WriteLine(s);