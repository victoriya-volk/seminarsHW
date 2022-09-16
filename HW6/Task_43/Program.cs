// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void CrossingPoint (float b1, float k1, float b2, float k2)
{
    float pointX =(b2-b1)/(k1-k2);
    float pointY = k1 * pointX + b1;
    Console.WriteLine($"{Math.Round(pointX, 1)}, {Math.Round(pointY,1)}");
}

CrossingPoint(2, 5, 4, 9);
CrossingPoint(-1, 2, 1, -3);