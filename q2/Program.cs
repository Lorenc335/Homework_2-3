Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 100) Console.WriteLine("В полученном числе нет третьего символа");
if (a> 1000) a = a/ 10;
else
{
    {
        a = a% 10;
        Console.Write("В полученном числе третий символ равен ");
        Console.WriteLine(a);
    }
}