static int[] CreateArray()
{
    int n = new Random().Next(2, 10);
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
        Console.Write(array[i]);
        Console.Write(' ');
    }
    Console.WriteLine(" ");
    return array;
}

static int chetnoe(int[] array)
{
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) k ++;
    }
    Console.Write("Четных: ");
    return k;
}

Console.Write("Массив: ");
Console.WriteLine(chetnoe(CreateArray()));