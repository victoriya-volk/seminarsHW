Console.WriteLine("Введите число A");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C");
int numC = Convert.ToInt32(Console.ReadLine());

int max = numA;

if (max < numB) 
{
    max = numB;
}
if  (max < numC) 
{
    max = numC;
}

Console.WriteLine($"max = {max}");