static int[, ] Matrix()
{
    int[, ] matrix = new int[5, 5];
    return FillMatrix(matrix);
}
static int[, ] FillMatrix(int[, ] matrix)
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
static void Sort(int[, ] matrix)
{
    Console.WriteLine();
    int temp;
    for (int k = 0; k < 5; k++)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = i + 1; j < 5; j++)
            {
                if (matrix[k, i] < matrix[k, j])
                {
                    temp = matrix[k, i];
                    matrix[k, i] = matrix[k, j];
                    matrix[k, j] = temp;
                }
            }
        Console.Write(matrix[k, i]);
        Console.Write(" ");
        }
    Console.WriteLine();
    }
}
Sort(Matrix());