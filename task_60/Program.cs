// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)

// 45(1,0,0) 53(1,0,1)

int[,,] matrix = FillMatrix(2, 2, 2, 10, 100);
const int START = 10;



int[,,] FillMatrix(int x, int y, int z, int leftRange, int rightRange)
{
    int[,,] matr = new int[x, y, z];
    int[] uniqArr = GetUniqueValue(matr);
    int temp = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = uniqArr[temp++];
                Console.Write($"{matr[i, j, k]}({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
    }
    return matr;
}
int[] GetUniqueValue(int[,,] matr)
{
    int[] uniqueArr = new int[matr.GetLength(0) * matr.GetLength(1) * matr.GetLength(2)];
    int t = START;
    for (int i = 0; i < uniqueArr.Length; i++)
    {
        uniqueArr[i] = t;
        t = t + 1;
    }
    return uniqueArr;
}

void PrintMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write(matr[i, j, k] + " ");
            }
            Console.WriteLine();
        }
    }
}

