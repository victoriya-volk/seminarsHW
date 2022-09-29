// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumOfNumbers (int M, int N)
{
    if (M < N)
    {
        return SumOfNumbers(M + 1, N) + M;
    }
    else if (M > N)
    {
        return SumOfNumbers(N + 1, M) + N;
    }
    else 
    {
        return M;
    }
}
 Console.WriteLine(SumOfNumbers(1, 15));
 Console.WriteLine(SumOfNumbers(4, 8));
 Console.WriteLine(SumOfNumbers(8, 4));