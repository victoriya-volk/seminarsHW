// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив,
//   добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int [,,] CreateThreeDimentionalMatrix (int X, int Y, int Z)
{
    int [] chackingNumbers = new int [X * Y * Z];
    int [,,] newMatrix = new int [X, Y, Z];
    int count = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < newMatrix.GetLength(2); k++)
            {
                int newNum = new Random().Next( 10, 100);
                int num = 0;
                while (num < chackingNumbers.Length)
                {
                    if (newNum == chackingNumbers[num])
                    {
                        num = 0;
                        newNum = new Random().Next( 10, 100);
                    }
                    else
                    {
                        num++;
                    }
                }
                chackingNumbers[count] = newNum;
                newMatrix[i, j, k] = newNum;
                count += 1;
            }
        }
    }
    return newMatrix;
}

void PrintThreeDimentionalMatrix (int [,,] threeDimentionalMatrix)
{
    for (int i = 0; i < threeDimentionalMatrix.GetLength(0); i++)
    {
        Console.WriteLine($"{i} border");
        for (int j = 0; j < threeDimentionalMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < threeDimentionalMatrix.GetLength(2); k++)
            {
                Console.Write($"  {threeDimentionalMatrix[i, j, k]}({i}, {j}, {k})");
            }
            Console.WriteLine();
        }
    }
}

int [,,] threeDimentionalMatrix = CreateThreeDimentionalMatrix(2, 2, 2);
int [,,] threeDimentionalMatrix2 = CreateThreeDimentionalMatrix(3, 2, 2);

PrintThreeDimentionalMatrix(threeDimentionalMatrix);
PrintThreeDimentionalMatrix(threeDimentionalMatrix2);

