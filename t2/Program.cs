static int[] CreateArray()
{
    int n = new Random().Next(5, 10);
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(1, 100);
        Console.Write(array[i]);
        Console.Write(' ');
    }
    Console.WriteLine(" ");
    return array;
}
static int summa(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) sum = sum + array[i];
    }
    Console.Write("Summa chisel s nechetnimi indexami:");
    return sum;
}
Console.Write("Array: ");
Console.WriteLine(summa(CreateArray()));