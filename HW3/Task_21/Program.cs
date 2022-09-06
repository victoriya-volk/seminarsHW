Console.WriteLine("Введите координату X точки A");
int AX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки A");
int AY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки A");
int AZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X точки B");
int BX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B");
int BY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B");
int BZ = Convert.ToInt32(Console.ReadLine());

double distAB = Math.Sqrt(Math.Pow(BX - AX, 2)+ Math.Pow(BY - AY, 2)+ Math.Pow(BZ - AZ, 2));

Console.WriteLine(Math.Round(distAB, 2));
