// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int functionAckerman (int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return functionAckerman(m - 1, 1);
    else if (m > 0 && n > 0) 
    {  
        return functionAckerman(m-1, functionAckerman(m, n-1));
    }
    else return -1;
}

Console.WriteLine(functionAckerman(0, 3));
Console.WriteLine(functionAckerman(2, 3));
Console.WriteLine(functionAckerman(3, 2));
Console.WriteLine(functionAckerman(3, 3));