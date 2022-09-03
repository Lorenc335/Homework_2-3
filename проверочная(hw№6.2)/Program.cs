static int[] Array()
{
    int[] array = new int[10];
    for (int i = 0; i < 10; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }
    return array;
}

static int[] SumFirstFinish(int[] array)
{
    int n = 10;
    int[] newarray = new int[10];
    for (int i = 0; i < n; i++)
    {
        newarray[i] = (array[i] + array[n - 1]);
        n--;
        Console.Write(newarray[i]);
        Console.Write(", ");
    }
    return newarray;
}

Console.WriteLine("Данный массив создан посредством сложения пар аргументов первого массива");
SumFirstFinish(Array());