Console.WriteLine("Введите 5-тизначное число");
int numZ = Convert.ToInt32(Console.ReadLine());

if (numZ > 9999 && numZ < 99999) 
{
    
    if (numZ / 10000 == numZ % 10 && numZ / 1000 % 10 == numZ % 100 / 10)
    {
        Console.WriteLine($"{numZ} - это палиндром!");
    }
    else 
    {
        Console.WriteLine($"{numZ} - это НЕ палиндром.");
    }
}
else 
{
    Console.WriteLine("Это число не подходит для моей программы(");
}