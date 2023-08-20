// See https://aka.ms/new-console-template for more information
Print2DArray(Solution.genSpiral(4));
Print2DArray(Solution.genSpiral(5));
Print2DArray(Solution.genSpiral(6));
Print2DArray(Solution.genSpiral(8));
Print2DArray(Solution.genSpiral(10));


 static void Print2DArray<T>(T[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
}