// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


void FillArray(int[,] number)     //Заполняем массив случайными цифрами
{
    for (int m = 0; m < number.GetLength(0); m++)
    {
        for (int n = 0; n < number.GetLength(1); n++)
        {
            number[m, n] = new Random().Next(-1, 11);
        }
    }
}
void PrintArray(int[,] printnumb)              //Выводим массив на экран
{
    for (int m = 0; m < printnumb.GetLength(0); m++)
    {
        for (int n = 0; n < printnumb.GetLength(1); n++)
        {
            Console.Write($"|{printnumb[m, n]}|  ");
        }
        Console.WriteLine();
    }
}
int[,] SelectionSort(int[,] num)                //Сортируем строки массива от max до min
{
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
        {
            int maxPosition = j;
            for (int k=j+1; k< num.GetLength(1); k++)
        {
           if (num[i,k] > num[i, maxPosition]) maxPosition = k; 
        }
        int temp = num[i,j];
        num[i,j] = num[i,maxPosition];
        num[i,maxPosition] = temp;
        }
    }
return num;        
}
int[,] array = new int[5, 6];       
FillArray(array);
PrintArray(array);
Console.WriteLine();
SelectionSort(array);
PrintArray(array);