static int[] CreateArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
    return array;
}

static int chetnoe(int[] array)
{
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) k ++;
    }
    return k;
}
Console.Write("Введите число аргументов массива : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Массив : ");
Console.WriteLine(CreateArray(n));
Console.Write("Массив содержит четных аргументов - ");
Console.WriteLine(chetnoe(CreateArray(n)));