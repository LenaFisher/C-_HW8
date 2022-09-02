// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 
// 1 строка

int[,] matrix = FillMatrix(4, 4, 0, 10);
Console.WriteLine("Первоначальный массив:");
PrintMatrix(matrix);
Console.WriteLine();
int[] arrayOfSum = StringWithMinSumOfElements(matrix);
// PrintArray(arrayOfSum);
int lineNumber = NumberOfMinString(arrayOfSum);
Console.WriteLine(lineNumber + " строка");




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


int[] StringWithMinSumOfElements(int[,] matr)
{
    int[] array = new int[matr.GetLength(0)];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum = sum + matr[i, j];
        }
        array[i] = sum;
    }
    return array;
}

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
// }

int NumberOfMinString(int[] arr)
{
    int min = arr[0];
    int lineNumber = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            lineNumber = i + 1;
        }
    }
    return lineNumber;
}
