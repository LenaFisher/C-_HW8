// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

int[,] matrix = FillMatrix(3, 4, 0, 10);
Console.WriteLine("Первоначальный массив:");
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Упорядоченный по возрастанию массив:");
OrderedFromMinToMax(matrix);
PrintMatrix(matrix);


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
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}


void OrderedFromMinToMax(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1) - 1; j++)
        {
            for (int m = j + 1; m < matr.GetLength(1); m++)
            {
                if (matr[i, j] > matr[i, m])
                {
                    int temp = matr[i, m];
                    matr[i, m] = matr[i, j];
                    matr[i, j] = temp;
                }
            }
        }
    }
}

// void SelectionSort(int[,] matr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int i = 0; i < matr.GetLength(1); i++)
//         {
//             int minPosition = i;
//             for (int j = i + 1; j < matr.Length; j++)
//             {
//                 if (matr[j] < matr[minPosition])
//                 {
//                     minPosition = j;
//                 }
//             }
//             int temp = matr[i];
//             matr[i] = matr[minPosition];
//             matr[minPosition] = temp;
//         }
//     }
// }