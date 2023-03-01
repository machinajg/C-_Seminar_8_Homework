// Задайте две матрицы. Напишите программу, которая будет находить произведение
//  двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


void FillArray(int[,] coll)     //Заполняем массив случайными цифрами
{
    for (int m = 0; m < coll.GetLength(0); m++)
    {
        for (int n = 0; n < coll.GetLength(1); n++)
        {
            coll[m, n] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] num)              //Выводим массив на экран
{
    for (int m = 0; m < num.GetLength(0); m++)
    {
        for (int n = 0; n < num.GetLength(1); n++)
        {
            Console.Write($"|{num[m, n]}|  ");
        }
        Console.WriteLine();
    }
}
void ProductMatr(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixResult = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
        Console.WriteLine("умножение матриц невозможно");
    else
        for (int i = 0; i < matrixA.GetLength(0); ++i)
        {
            for (int j = 0; j < matrixB.GetLength(1); ++j)
            {
                matrixResult[i, j] = 0;
                for (int k = 0; k < matrixA.GetLength(1); ++k)
                {
                    matrixResult[i, j] += matrixA[i, k] * matrixB[k, j];
                }
                Console.Write($"|{matrixResult[i, j]}|  ");
            }
            Console.WriteLine();
        }
}

int[,] array = new int[2, 3];
int[,] arr = new int[3, 4];
FillArray(array);
FillArray(arr);
PrintArray(array);
Console.WriteLine();
PrintArray(arr);
Console.WriteLine();
ProductMatr(array, arr);

