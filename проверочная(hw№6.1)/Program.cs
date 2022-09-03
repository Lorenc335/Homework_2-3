static int[] ArrayRandom()
{
    int[] array = new int[123];
    for (int i = 0; i < 123; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

static int Args1099(int[] array)
{
    int count = 0;
    for (int i = 0; i < 123; i++)
    {
        if (array[i] == 10) count++;
        if (array[i] == 99) count++;
    }
    return count;
}

Console.Write("количество аргументов со значением 10 и 99 в массиве равно ");
Console.WriteLine(Args1099(ArrayRandom()));