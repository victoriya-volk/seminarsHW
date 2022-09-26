// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.WriteLine("Введите количество строк:");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int numN = Convert.ToInt32(Console.ReadLine());

int [,] NewArray (int m, int n)
{
    int [,] newArr = new int [m, n];
    for (int i =0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArr[i , j] = new Random().Next( 1, 10);
        }
    }
    return newArr;
}

void PrintArr (int [,] arr) 
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++){
            Console.Write($"{arr[i, j]} ");
        } 
        Console.WriteLine();
    }
    
}
int [,] myArr =  NewArray(numM, numN);
PrintArr(myArr);
Console.WriteLine();

void MinSumRow (int [,] array) 
{
    int minSum = 0;
    for (int k = 0; k < array.GetLength(1); k++)
    {
        minSum+=array[0, k];
    }
    int minSumRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int rowNumsSum = 0;
        for( int j = 0; j < array.GetLength(1); j++)
        {
            rowNumsSum += array[i, j];
            
        }
        if (rowNumsSum < minSum)
        {
            minSum = rowNumsSum;
            minSumRow = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов в {minSumRow + 1} строке");
}

MinSumRow(myArr);