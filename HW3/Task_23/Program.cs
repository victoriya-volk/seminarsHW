Console.WriteLine("Введите число");
int numZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Идет вычисление...");

for (int i = 1; i <= numZ; i++)
{
    Console.WriteLine(Math.Pow(i, 3));
}
