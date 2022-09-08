static void Matrix()
{
    int[, ] matrix = new int[5, 5];
    FillMatrix(matrix);
}

static void FillMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j< matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-9, 9);
            Console.Write(matrix[i, j]);
            Console.Write(" ");
        }
    Console.WriteLine();
    }
    ArraySum(matrix);
}

static void ArraySum(int[, ] matrix)
{
    int s = 0;
    int[] arraycreate = new int[5];
    Console.WriteLine();
    for (int i = 0; i < 5; i++)
    {
        s = 0;
        for (int j = 0; j < 5; j++)
        {
            s = s + matrix[j, i];
        }
        arraycreate[i] = s;
        Console.Write(arraycreate[i]);
        Console.Write(" ");
    }
}
Matrix();