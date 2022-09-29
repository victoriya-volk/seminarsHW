// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Clear();
int [,] matpixA = new int[,] {{2, 4}, {3, 2}};
int [,] matrixB = new int[,] {{3, 4}, {3, 3}};
//My example
int [,] matrixFirst = new int[,] {{1, 2, 3}, {1, 2, 3}, {1, 2, 3}};
int [,] matrixSecond = new int[,] {{3, 2, 1}, {3, 2, 1}, {3, 2, 1}};
int [,] matrixWrong = new int [,] {{4, 5, 6}, {4, 5, 6}};

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

int [,] MultiMatrix (int [,] arrayA, int [,] arrayB)
{
    if (arrayA.GetLength(1) == arrayB.GetLength(0))
    {
        int [,] multyMatr = new int [arrayA.GetLength(0), arrayB.GetLength(1)];
        for (int i = 0; i < multyMatr.GetLength(0); i++)
        {
            for (int j = 0; j < multyMatr.GetLength(1); j++)
            {
                multyMatr[i, j] = MultiplicationRowCol(arrayA, i, arrayB, j);
            }
        }
        return multyMatr;
    }
    else 
    {
        Console.WriteLine("Эти матрицы не подходят для умножения");
        return new int [1,1];
    }
    
}

int MultiplicationRowCol (int [,] arrA, int row, int [,] arrB, int col)
{
    int multiRowCol = 0;
    for (int i = 0; i < arrA.GetLength(0); i++)
    {
        multiRowCol += arrA[row, i]* arrB[i, col];
    }
    return multiRowCol;
}

int [,] multiMatrixAB = MultiMatrix(matpixA, matrixB);
PrintArr(multiMatrixAB);
Console.WriteLine("My Example");
int [,] matrixThird = MultiMatrix(matrixFirst, matrixSecond);
PrintArr(matrixThird);
Console.WriteLine("My Example");
int [,] wrongMulti = MultiMatrix(matrixFirst, matrixWrong); 



