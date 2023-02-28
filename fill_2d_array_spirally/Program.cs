// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array = new int[4, 4];

void PrintArray(int[,] arr)
{
    for (int m = 0; m < arr.GetLength(0); m++)
    {
        for (int n = 0; n < arr.GetLength(1); n++)
        {
            Console.Write($"|{arr[m, n]}|  ");
        }
        Console.WriteLine();
    }
}
void FillArray(int row, int col)
{
    int a = 01;
    if (array[row, col] == 0)
    {
        array[row, col] = a++;
        FillArray(row, col + 1);
        FillArray(row - 1, col);
        FillArray(row, col - 1);
        FillArray(row + 1, col);
    }
}
PrintArray(array);
FillArray(0,0);
PrintArray(array);
Console.WriteLine();
