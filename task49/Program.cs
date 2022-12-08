int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //2
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1); // 2- 3
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
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
int FindElement(int[,] matrix, int row, int column)
{
    int x = matrix[row, column];
    return x;
}
Console.WriteLine("Введите размер строки:");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер столбца:");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = CreateMatrixRndInt(row, column, 1, 10);
Console.WriteLine("Введите индекс строки:");
int indexRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца:");
int indexColumn = Convert.ToInt32(Console.ReadLine());
if (indexRow > row || indexColumn > column) Console.WriteLine("Введите числа входящие в диапозон матрицы");
else 
{
    PrintMatrix(matrix);
    Console.WriteLine();
    int res = FindElement(matrix, indexRow, indexColumn);
    Console.WriteLine(res);
}