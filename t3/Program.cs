static double CreateArray()
{
    int n = new Random().Next(5, 10);
    double[] array = new double[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(-99, 99);
        Console.Write(array[i]);
        Console.Write(' ');
    }
    Console.WriteLine(" ");
    return raznica(n, array);
}
static double raznica(int n, double[] array)
{
    int i = 0;
    double min = array[0];
    double max = array[0];
    
    for (i = 0; i < n; i++)
    {
        if (min > array[i]) min = array[i];
        if (max < array[i]) max = array[i];
    }
    max = max - min;
    Console.Write("Разница max и min: ");
    return max;
}
Console.Write("Аргументы массива: ");
Console.WriteLine(CreateArray());