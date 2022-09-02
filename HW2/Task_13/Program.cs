Console.WriteLine("Введите число для проверки");
int numZ = Convert.ToInt32(Console.ReadLine());

if (numZ < 100) 
{
    Console.WriteLine("Нет третьей цифры!");
}
else if (numZ >= 1000)
{
    while (numZ >= 999)
    {
        numZ = numZ / 10;
    }
    Console.WriteLine(numZ % 10);
}
else 
{
    Console.WriteLine(numZ % 10);
}



