static int[, ] Matrix()
{
    int[, ] matrix = new int[5, 5];
     return FillMatrix(matrix);
}

static int[, ] FillMatrix(int[, ] matrix)
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
    return matrix;
}
static void Index(int[, ] matrix)
{
    Console.Write("Введите первое число двумерной координаты - ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число двумерной координаты - ");
    int y = Convert.ToInt32(Console.ReadLine());
    if (x > 5 | y > 5) Console.WriteLine("Такой координаты не найдено ");
    else 
    {
        Console.Write("Выбранная координата содержит число - ");
        Console.WriteLine(matrix[x - 1, y - 1]);
    }
}
Index(Matrix());