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
double[] MiddleArifmetic(int[,] matrix)
{
    int size = matrix.GetLength(1);
    double[] result = new double[size];
    int count = 0;
    
    double[] answer = new double[size];
    for (int j = 0; j < matrix.GetLength(1); j++) 
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {      
            result[count] +=matrix[i, j];
            
            
        }
        //result[count] =result[count] / matrix.GetLength(0);
        result[count] =Math. Round(result[count] / matrix.GetLength(0), 1);
        count++;
            
    }
    
    return result;
}
void PrintArray(double[] array)

{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");

}


int[,] res = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(res);
Console.WriteLine();
double[] array2D = MiddleArifmetic(res);
PrintArray(array2D);