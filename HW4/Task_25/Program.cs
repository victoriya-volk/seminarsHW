Console.WriteLine("Введите число:");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень для возведения:");
int numB = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 0; i < numB; i++)
{
 result = result * numA;
}
Console.WriteLine();
Console.WriteLine(result);
