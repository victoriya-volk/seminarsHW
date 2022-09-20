// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            newArr[i , j] = new Random().Next( 0, 10);
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

void MiddleSumOfCol (int [,] arr)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double middleSum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            middleSum += arr [j, i];
        }
        Console.WriteLine($"СА в столбце {i+1} {Math.Round(middleSum / arr.GetLength(0), 1)}");
    }
}

MiddleSumOfCol(myArr);
Console.WriteLine("Пример из задачи для проверки:");
int [,] example = {{1,4,7,2}, {5,9,2,3}, {8,4,2,4}};
MiddleSumOfCol(example);