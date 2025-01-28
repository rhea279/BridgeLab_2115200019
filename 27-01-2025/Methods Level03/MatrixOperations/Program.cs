using System;

class MatrixOperations
{
    static int[,] CreateMatrix(int rows, int cols)
    {
        Random random = new Random();
        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(1, 10);
            }
        }

        return matrix;
    }

    static int[,] AddMatrices(int[,] a, int[,] b)
    {
        int rows = a.GetLength(0), cols = a.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = a[i, j] + b[i, j];
            }
        }

        return result;
    }

    static int[,] SubtractMatrices(int[,] a, int[,] b)
    {
        int rows = a.GetLength(0), cols = a.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = a[i, j] - b[i, j];
            }
        }

        return result;
    }

    static int[,] MultiplyMatrices(int[,] a, int[,] b)
    {
        int rows = a.GetLength(0), cols = b.GetLength(1);
        int common = a.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                for (int k = 0; k < common; k++)
                {
                    result[i, j] += a[i, k] * b[k, j];
                }
            }
        }

        return result;
    }

    static void DisplayMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j],3}");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.Write("Enter rows and columns for matrices: ");
        var input = Console.ReadLine().Split();
        int rows = int.Parse(input[0]), cols = int.Parse(input[1]);

        int[,] matrix1 = CreateMatrix(rows, cols);
        int[,] matrix2 = CreateMatrix(rows, cols);

        Console.WriteLine("Matrix 1:");
        DisplayMatrix(matrix1);

        Console.WriteLine("Matrix 2:");
        DisplayMatrix(matrix2);

        Console.WriteLine("Addition:");
        DisplayMatrix(AddMatrices(matrix1, matrix2));

        Console.WriteLine("Subtraction:");
        DisplayMatrix(SubtractMatrices(matrix1, matrix2));

        Console.WriteLine("Multiplication:");
        DisplayMatrix(MultiplyMatrices(matrix1, matrix2));
    }
}
