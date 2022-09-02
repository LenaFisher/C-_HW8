// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int arrayLength = 4;
int currentValue = 1;
int[,] array = new int[arrayLength, arrayLength];

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillArray(int row, int column, int length, int position)
{
    while (column < length + position)
    {
        array[row, column++] = currentValue++;
        Console.WriteLine("row =" + row);
        Console.WriteLine("column =" + column);
        Console.WriteLine("___________");
    }

    row++;
    column--;
    while (row < length)
    {
        array[row++ + position, column + position] = currentValue++;
        Console.WriteLine("row =" + row);
        Console.WriteLine("column =" + column);
        Console.WriteLine("___________");
    }

    row--;
    column--;

    while (column >= 0)
    {
        array[row + position, position + column--] = currentValue++;
        Console.WriteLine("row =" + row);
        Console.WriteLine("column =" + column);
        Console.WriteLine("___________");
    }

    row--;
    column++;
    while (row > 0)
    {
        array[row--, column + position] = currentValue++;

        Console.WriteLine("row =" + row);
        Console.WriteLine("column =" + column);
        Console.WriteLine("___________");
    }
    position++;
    if (position < arrayLength / 2)
    {
        FillArray(1, 1, arrayLength / 2, position);
    }
}

PrintArray(array);
FillArray(0, 0, arrayLength, 0);
PrintArray(array);