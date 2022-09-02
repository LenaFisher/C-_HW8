// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49


int[,] matrix1 = FillMatrix(4, 4, 0, 10);
Console.WriteLine("Первый массив:");
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = FillMatrix(4, 4, 0, 10);
Console.WriteLine("Второй массив:");
PrintMatrix(matrix2);
Console.WriteLine();
Console.WriteLine("Итоговый массив:");
int[,] matrix3 = ProductOfMatrix(matrix1, matrix2);
PrintMatrix(matrix3);




int[,] FillMatrix(int rows, int columns, int leftRange, int rightRange)
{
    int[,] matr = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(leftRange, rightRange);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] ProductOfMatrix(int[,] matr1, int[,] matr2)
{
    int[,] newMatr = new int[matr1.GetLength(0), matr1.GetLength(1)];
    for (int i = 0; i < newMatr.GetLength(0); i++)
    {
        for (int j = 0; j < newMatr.GetLength(1); j++)
        {
            newMatr[i, j] = matr1[i, j] * matr2[i, j];
        }

    }
    return newMatr;
}