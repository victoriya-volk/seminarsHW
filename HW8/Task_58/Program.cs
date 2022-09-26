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
        int [,] multiMatrix  = new int [arrayA.GetLength(1), arrayB.GetLength(0)];
        for (int i = 0; i < arrayB.GetLength(0); i++)
        {
            for (int j = 0; j < arrayA.GetLength(1); j++)
            {
                int newMultiNum = 0;
                newMultiNum += arrayA[i, j] * arrayB[j, i]
                Console.WriteLine(newMultiNum);
            }
        }
        return multiMatrix;
    }
    else 
    {
        Console.WriteLine("Умножение не возможно (Количество столбцов матрицы 1 не равно количеству строк матрицы 2)");
        return arrayA;
    }
}

int [,] multiMatrixAB = MultiMatrix(matpixA, matrixB);
PrintArr(multiMatrixAB);



