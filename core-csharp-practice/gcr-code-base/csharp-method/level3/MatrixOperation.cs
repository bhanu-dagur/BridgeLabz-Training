using System;

class MatrixOperations
{
    static Random rand = new Random();

    public static int[,] CreateMatrix(int rows, int cols)
    {
        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = rand.Next(1, 10); // random 1 to 9
            }
        }
        return matrix;
    }

    public static void DisplayMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    public static int[,] AddMatrix(int[,] a, int[,] b)
    {
        int[,] result = new int[a.GetLength(0), a.GetLength(1)];

        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1); j++)
                result[i, j] = a[i, j] + b[i, j];

        return result;
    }
        public static int[,] SubtractMatrix(int[,] a, int[,] b)
    {
        int[,] result = new int[a.GetLength(0), a.GetLength(1)];

        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < a.GetLength(1); j++)
                result[i, j] = a[i, j] - b[i, j];

        return result;
    }

    public static int[,] MultiplyMatrix(int[,] a, int[,] b)
    {
        int[,] result = new int[a.GetLength(0), b.GetLength(1)];

        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                for (int k = 0; k < b.GetLength(0); k++)
                {
                    result[i, j] += a[i, k] * b[k, j];
                }
            }
        }
        return result;
    }

    // Transpose
    public static int[,] TransposeMatrix(int[,] matrix)
    {
        int[,] transpose = new int[matrix.GetLength(1), matrix.GetLength(0)];

        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                transpose[j, i] = matrix[i, j];

        return transpose;
    }

    public static int Determinant2x2(int[,] m)
    {
        return (m[0, 0] * m[1, 1]) - (m[0, 1] * m[1, 0]);
    }

    public static int Determinant3x3(int[,] m)
    {
        return m[0,0]*(m[1,1]*m[2,2]-m[1,2]*m[2,1])
             - m[0,1]*(m[1,0]*m[2,2]-m[1,2]*m[2,0])
             + m[0,2]*(m[1,0]*m[2,1]-m[1,1]*m[2,0]);
    }

    public static void Inverse2x2(int[,] m)
    {
        int det = Determinant2x2(m);

        if (det == 0)
        {
            Console.WriteLine("Inverse not possible");
            return;
        }

        Console.WriteLine("Inverse Matrix:");
        Console.WriteLine(m[1,1] / (double)det + "\t" + -m[0,1] / (double)det);
        Console.WriteLine(-m[1,0] / (double)det + "\t" + m[0,0] / (double)det);
    }
    public static void Inverse3x3()
    {
        Console.WriteLine("Inverse of 3x3 is complex for beginners 🙂");
        Console.WriteLine("Concept based question only");
    }

    static void Main()
    {
        int[,] A = CreateMatrix(2, 2);
        int[,] B = CreateMatrix(2, 2);

        Console.WriteLine("Matrix A:");
        DisplayMatrix(A);

        Console.WriteLine("Matrix B:");
        DisplayMatrix(B);

        Console.WriteLine("Addition:");
        DisplayMatrix(AddMatrix(A, B));

        Console.WriteLine("Subtraction:");
        DisplayMatrix(SubtractMatrix(A, B));

        Console.WriteLine("Multiplication:");
        DisplayMatrix(MultiplyMatrix(A, B));

        Console.WriteLine("Transpose of A:");
        DisplayMatrix(TransposeMatrix(A));

        Console.WriteLine("Determinant of A (2x2): " + Determinant2x2(A));

        Inverse2x2(A);
    }
}
