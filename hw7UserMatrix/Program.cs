static void MatrixOfUser()
{
    Console.Write("Введите число строк для построения матрицы - ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число столбцов - ");
    int m = Convert.ToInt32(Console.ReadLine());
    double[, ] matrix = new double[n, m];
    FillMatrix(matrix);
}

static void FillMatrix(double[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 9);
            Console.Write(matrix[i, j]);
        }
        Console.WriteLine();
    }
}
MatrixOfUser();