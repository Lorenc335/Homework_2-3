static int[, ] Matrix()
{
    int[, ] matrix = new int[4, 3];
    return RandomInside(matrix);
}
static int[, ] RandomInside(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-9, 9);
            Console.Write(matrix[i, j]);
            Console.Write(" ");
        }
    Console.WriteLine();
    }
    return matrix;
}

static int SumString(int[, ] matrix)
{
    Console.WriteLine("Строка, сумма аргументов которой минимальна, является - ");
    int sum = 0;
    int minsum = 100;
    int index = 0;
    for (int i = 0; i < 4; i++)
    {
        sum = 0;
        for (int j = 0; j < 3; j++)
        {
        
            sum = sum + matrix[i, j];
            if (sum < minsum)
            {
                minsum = sum;
                index = i;
            }
        }
    }
    return index;
}
Console.WriteLine(SumString(Matrix()));