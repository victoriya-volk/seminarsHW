// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void SearchUserElem (int [,] arr)
{
    Console.WriteLine("Введите номер строки:");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца:");
    int y = Convert.ToInt32(Console.ReadLine());
    if (x < arr.GetLength(0) && y < arr.GetLength(1)) 
    {
        Console.WriteLine($"Это {arr[x,y]}");
    }
    
    else Console.WriteLine("Такого элемента нет в этом массиве.");
}

SearchUserElem(myArr);