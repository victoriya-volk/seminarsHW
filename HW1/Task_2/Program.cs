Console.WriteLine("Введите число A");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA > numB) 
{
    Console.WriteLine($"max = {numA}, min = {numB}");
}
else
{
   Console.WriteLine($"max = {numB}, min = {numA}");
};
