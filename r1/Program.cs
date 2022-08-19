Console.Write("Введите пятизначное число :");
int a = Convert.ToInt32(Console.ReadLine());
int x = a/10000;
int z = a%10;
if (x == z)
{
    a = a - (x * 10000 + z);
    x = a / 1000;
    z = (a % 100) / 10;
    if (x == z) Console.WriteLine("Azor roza; Yes");
    else {Console.WriteLine("Kabanchik, no boku; No");}
}
else {Console.WriteLine("Kabanchik, no boku; No");}