Console.WriteLine("Введите число:");
int numZ = Convert.ToInt32(Console.ReadLine());

int result = 0;
while (numZ > 0)
{
    result = result + numZ % 10;
    numZ = numZ / 10;
}
Console.WriteLine();
Console.WriteLine(result);



