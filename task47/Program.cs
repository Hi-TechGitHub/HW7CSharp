

double[,] CreateMatrixRnddouble(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() * (max - min) - min;
            matrix[i, j] = Math.Round(matrix[i, j], 1);
        }
    }
    //matrix = Math.Round(matrix, 1 );
    return matrix;
}
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

double[,] matrix1 = CreateMatrixRnddouble(3, 4, 1, 10);
//MatrixRound(matrix1);
PrintMatrix(matrix1);
