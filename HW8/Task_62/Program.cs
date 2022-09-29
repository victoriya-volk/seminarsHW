// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int [,]  matrixForSpiral = new int[4, 4];

int [,] FillSpiralMatrix (int [,] array, 
                            int length,
                            int x = 0, int y = 0, 
                            int content = 0)
{
    if (array[x, y] == 0)
    {
        if (x < array.GetLength(0) / 2)
        {
            if (x == 0 && x == y) 
            {
                while (y < length)
                {
                    array[x, y] = content+=1;
                    y+=1;
                }
                return FillSpiralMatrix(array, length - 1, x + 1, y - 1 , content);
            }
            else if (x > 0 && x == y ) 
            {
                while (y <= length + 1)
                {
                    array[x, y] = content+=1;
                    y+=1;
                }
                return FillSpiralMatrix(array, length - 1, x + 1, y - 1, content);
            }
            else if (x < y)
            {
                while (x <= length)
                {
                    array[x, y] = content+=1;
                    x += 1;
                }
                return FillSpiralMatrix(array, length - 1, x - 1, y - 1, content);
            }
        }
        else 
        {
            if (x == y) 
            {
                while (y > length)
                {
                    array[x, y] = content+=1;
                    y -= 1;
                }
                return FillSpiralMatrix(array, length, x + 1, y + 1 , content);
            }
            else if (x > y && y > 0)
            {
                while (y >= 0)
                {
                    array[x, y] = content+=1;
                    y-=1;
                }
                return FillSpiralMatrix(array, length - 1, x - 1, y + 1, content);
            }
            else if (x > y && y > 0)
            {
                while (y >= 0)
                {
                    array[x, y] = content+=1;
                    y-=1;
                }
                return FillSpiralMatrix(array, length - 1, x - 1, y + 1, content);
            }
            else if (x > y && y == 0)
            {
                while (x >= length)
                {
                    array[x, y] = content += 1;
                    x -= 1;
                }
                return FillSpiralMatrix(array, length, x + 1, y + 1,  content);
            }
        }
    }
    return array;
}

void PrintArr (int [,] arr) 
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++){
            if (arr[i, j] < 10)Console.Write($"0{arr[i, j]} ");
            else Console.Write($"{arr[i, j]} ");
        } 
        Console.WriteLine();
    }
    
}

int [,] spiralMatrix = FillSpiralMatrix(matrixForSpiral, 4);
PrintArr(spiralMatrix);

// int [,] FillLine (int[,] arr, int x, int y, )

