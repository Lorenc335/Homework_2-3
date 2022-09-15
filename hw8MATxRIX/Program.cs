static int[, ] Matrix()
{
    int[, ] matrix = new int[3, 3];
    return RandomArgs(matrix);
}
static int[, ] RandomArgs(int[, ] matrix)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            matrix[i, j] =  new Random().Next(1, 4);
        }
    }
    return matrix;
}
static void MatrixMatrix()
{
    int[, ] matrix1 = Matrix();
    int[, ] matrix2 = Matrix();
    int sum = 0;
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            for (int l = 0; l < 3; l++)
            {
                sum = sum + matrix1[i, l] * matrix2[l, j];
            }
            Console.Write(sum);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}
MatrixMatrix();