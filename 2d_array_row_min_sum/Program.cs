// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
//  строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

void FillArray(int[,] coll)     //Заполняем массив случайными цифрами
{
    for (int m = 0; m < coll.GetLength(0); m++)
    {
        for (int n = 0; n < coll.GetLength(1); n++)
        {
            coll[m, n] = new Random().Next(-1, 11);
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
int[] GetRowSum(int[,] num)                //Суммируем элементы каждой строки
{                                           //и кладем их значения в одномерный массив
    string result = string.Empty;
    int[] res = new int[num.GetLength(0)];

    for (int i = 0; i < num.GetLength(0); i++)
    {
        int rowsum = 0;

        for (int j = 0; j < num.GetLength(1); j++)
        {
            rowsum += num[i, j];
            res[i] = rowsum;
        }
        
    Console.WriteLine($"{res[i]}  ");
    }
    
    return res;
}
void SelectionSort(int[] array)
{                                      //Находим номер строки с наименьшей суммой элементов       
    int minposition = 0;
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) minposition = i;
    }
    Console.Write($"номер строки с наименьшей суммой элементов: {minposition}");
}

int[,] array = new int[4, 3];
FillArray(array);
PrintArray(array);
Console.WriteLine();
GetRowSum(array);
SelectionSort(GetRowSum(array));
Console.WriteLine();

